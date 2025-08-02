const express = require("express");
const app = express();
const cors = require("cors");
const pool = require("./dbt"); 

// Configuración de CORS
app.use(cors({
  origin: '*',
  methods: ['GET', 'POST'],
  credentials: false
}));

// Middleware para procesar JSON y URL-encoded
app.use(express.json());
app.use(express.urlencoded({ extended: true }));

// Encabezado para respuestas JSON
app.use((req, res, next) => {
  res.setHeader('Content-Type', 'application/json; charset=utf-8');
  next();
});


app.get("/", (req, res) => {
  res.status(200).json({ status: "API funcionando" });
});

app.post("/api/Ingreso", async (req, res) => {
  const { nombre_usuario, contrasena } = req.body;

  console.log("Datos recibidos:", req.body);

  
  if (!nombre_usuario?.trim() || !contrasena?.trim()) {
    return res.status(400).json({
      error: "Faltan credenciales",
      detalles: "Se requieren nombre de usuario y contraseña"
    });
  }

  try {
    const client = await pool.connect();
    console.log("Conexión a DB establecida");

    const userResult = await client.query(
      "SELECT * FROM usuarios WHERE nombre_usuario = $1",
      [nombre_usuario.trim()]
    );

    if (userResult.rows.length === 0) {
      client.release();
      return res.status(401).json({
        error: "Credenciales inválidas",
        detalles: "Usuario no encontrado"
      });
    }

    const user = userResult.rows[0];

    // Verificación de contraseña
    if (user.contrasena !== contrasena) {
      client.release();
      return res.status(401).json({
        error: "Credenciales inválidas",
        detalles: "Contraseña incorrecta"
      });
    }

    client.release();

    
    return res.status(200).json({
      nombre_usuario: user.nombre_usuario.trim(),
      mensaje: "Autenticación exitosa"
    });

  } catch (err) {
   
    console.error("Error detallado:", {
      message: err.message,
      stack: err.stack,
      query: err.query,
      parameters: err.parameters
    });

    return res.status(500).json({
      error: "Error interno del servidor",
      detalles: process.env.NODE_ENV === 'development' ? err.message : undefined
    });
  }
});

// Manejo global de errores (fallback)
app.use((err, req, res, next) => {
  console.error("Error global:", err);
  res.status(500).json({
    error: "Error interno del servidor",
    detalles: process.env.NODE_ENV === 'development' ? err.message : undefined
  });
});

// Iniciar servidor
const PORT = process.env.PORT || 3001;
app.listen(PORT, () => {
  console.log(`Servidor corriendo en http://localhost:${PORT}`);
});
