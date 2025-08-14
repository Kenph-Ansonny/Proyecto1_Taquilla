const express = require("express");
const cors = require("cors");
const pool = require("./dbt");

const app = express();

app.use(cors({ origin: '*', methods: ['GET', 'POST'], credentials: false }));
app.use(express.json());
app.use(express.urlencoded({ extended: true }));
app.use((req, res, next) => {
  res.setHeader('Content-Type', 'application/json; charset=utf-8');
  next();
});

app.get("/", (req, res) => {
  res.status(200).json({ status: "API funcionando" });
});

app.post("/api/Registro", async (req, res) => {
  const { nombre, apellido, correo, contrasena } = req.body;

  if (!nombre || !apellido || !correo || !contrasena) {
    return res.status(400).json({ error: "Todos los campos son requeridos" });
  }

  try {
   
    const [resultMaxCliente] = await pool.query("SELECT MAX(ID_Cliente) AS maxId FROM Cliente");
    const nuevoID_Cliente = (resultMaxCliente[0].maxId || 0) + 1;

    // contador
    const [resultMaxUsuario] = await pool.query("SELECT MAX(ID_Usuario) AS maxId FROM Usuarios");
    const nuevoID_Usuario = (resultMaxUsuario[0].maxId || 0) + 1;

    // nombre usuario generado
    const baseUsuario = correo.split('@')[0].toLowerCase().replace(/[^a-z0-9]/g, '');
    let nombreUsuarioFinal = baseUsuario;
    let contador = 1;

    while (true) {
      const [existe] = await pool.query(
        "SELECT * FROM Usuarios WHERE Nombre_Usuario = ?",
        [nombreUsuarioFinal]
      );
      if (existe.length === 0) break;
      nombreUsuarioFinal = `${baseUsuario}${contador}`;
      contador++;
    }

    // Insertar en Cliente
    await pool.query(
      `INSERT INTO Cliente (ID_Cliente, Nombre, Apellido, Correo)
       VALUES (?, ?, ?, ?)`,
      [nuevoID_Cliente, nombre.trim(), apellido.trim(), correo.trim()]
    );

    
    await pool.query(
      `INSERT INTO Usuarios (ID_Usuario, Nombre_Usuario, Contrasena, ID_Cliente, Identificador)
       VALUES (?, ?, ?, ?, ?)`,
      [nuevoID_Usuario, nombreUsuarioFinal, contrasena, nuevoID_Cliente, 1]
    );

    return res.status(201).json({
      mensaje: "Registro exitoso",
      id_cliente: nuevoID_Cliente,
      id_usuario: nuevoID_Usuario,
      nombre_usuario: nombreUsuarioFinal
    });

  } catch (error) {
    console.error("❌ Error al registrar:", error);
    return res.status(500).json({ error: "Error interno del servidor" });
  }
});

const PORT = process.env.PORT || 3002;
app.listen(PORT, () => {
  console.log(`Servidor corriendo en http://localhost:${PORT}`);
});
