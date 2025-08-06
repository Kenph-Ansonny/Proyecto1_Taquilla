const modal = document.getElementById('modalLogin');
const openBtn = document.querySelector('.login-btn');
const closeBtn = document.querySelector('.close');

openBtn.addEventListener('click', () => {
  modal.style.display = 'block';
});
closeBtn.addEventListener('click', () => {
  modal.style.display = 'none';
});
window.addEventListener('click', e => {
  if (e.target === modal) modal.style.display = 'none';
});

 document.getElementById("loginForm").addEventListener("submit", async (e) => {
  e.preventDefault(); // ¡Importante! Evita el envío tradicional del formulario

  const nombre_usuario = document.getElementById('usuarioInput').value;
  const contrasena = document.getElementById('contrasenaInput').value;

  try {
    const response = await fetch("http://localhost:3001/api/Ingreso", {
      method: "POST",
      headers: {
        "Content-Type": "application/json"
      },
       body: JSON.stringify({ nombre_usuario, contrasena })
    });

    if (response.ok) {
      const data = await response.json();
      alert("✅ " + data.mensaje);
    } else {
      const error = await response.json();
      alert("❌ Error: " + (error.error || "No autorizado"));
    }
  } catch (error) {
    console.error("Error al intentar iniciar sesión:", error);
    alert("🚫 Error de red o servidor no disponible");
  }
});