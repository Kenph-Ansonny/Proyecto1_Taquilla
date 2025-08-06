const mysql = require("mysql2/promise");
const dotenv = require("dotenv").config();


const pool = mysql.createPool({
  host: process.env.MYSQL_HOST,
  user: process.env.MYSQL_USER,
  password: process.env.MYSQL_PASSWORD,
  database: process.env.MYSQL_DATABASE,
  port: process.env.MYSQL_PORT,
  waitForConnections: true,
  connectionLimit: 10,
  queueLimit: 0,
  connectTimeout: 10000
});

pool.getConnection((err, connection) => {
  if (err) {
    console.error("❌ Error conectando a MySQL:", err);
  } else {
    console.log("✅ Conexión a MySQL exitosa");
    connection.release();
  }
});

module.exports = pool;
