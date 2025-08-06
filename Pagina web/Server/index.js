const express = require("express");
const app = express();
const cors = require("cors");

// Middlewares
app.use(cors({ origin: '*', methods: ['GET', 'POST'], credentials: false }));
app.use(express.json());
app.use(express.urlencoded({ extended: true }));
app.use((req, res, next) => {
  res.setHeader('Content-Type', 'application/json; charset=utf-8');
  next();
});

// Rutas
const authRoutes = require("../Server/routes/Ingreso.js");


app.use("/api", authRoutes);
app.use("/api/Ingreso", productoRoutes);
// app.use("/api/usuarios", usuarioRoutes);

// Ruta base
app.get("/", (req, res) => {
  res.status(200).json({ status: "API funcionando" });
});

// Manejo de errores
app.use((err, req, res, next) => {
  console.error("Error global:", err);
  res.status(500).json({ error: "Error interno del servidor" });
});

// Iniciar servidor
const PORT = process.env.PORT || 3001;
app.listen(PORT, () => {
  console.log(`🚀 Servidor corriendo en http://localhost:${PORT}`);
});
