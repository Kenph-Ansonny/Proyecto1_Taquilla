const express = require("express");
const cors = require("cors");
const pool = require("./dbt"); 

const app = express();

// === Middleware ===
app.use(cors({ origin: '*', methods: ['GET', 'POST'], credentials: false }));
app.use(express.json());
app.use(express.urlencoded({ extended: true }));
app.use((req, res, next) => {
  res.setHeader('Content-Type', 'application/json; charset=utf-8');
  next();
});

// === Ruta base ===
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
    const [rows] = await pool.query(
      "SELECT * FROM Usuarios WHERE Nombre_Usuario = ?",
      [nombre_usuario.trim()]
    );

    if (rows.length === 0) {
      return res.status(401).json({
        error: "Credenciales inválidas",
        detalles: "Usuario no encontrado"
      });
    }

    const user = rows[0];
    if (user.Contrasena !== contrasena) {
      return res.status(401).json({
        error: "Credenciales inválidas",
        detalles: "Contraseña incorrecta"
      });
    }

    const tipoUsuario = user.EsEmpleado === 1 ? "empleado" : "cliente";

    const datosUsuario = {
      id_usuario: user.ID_Usuario,
      nombre_usuario: user.Nombre_Usuario.trim(),
      tipo: tipoUsuario,
      id_relacionado: user.ID_Cliente ?? null,
      mensaje: "Autenticación exitosa"
    };

    return res.status(200).json(datosUsuario);

  } catch (err) {
    console.error("❌ Error detallado:", err);
    return res.status(500).json({
      error: "Error interno del servidor",
      detalles: process.env.NODE_ENV === 'development' ? err.message : undefined
    });
  }
});


const PORT = process.env.PORT || 3001;
app.listen(PORT, () => {
  console.log(`Servidor corriendo en http://localhost:${PORT}`);
});
