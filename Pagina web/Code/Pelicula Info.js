const modal = document.getElementById('modalLogin');
const openBtn = document.querySelector('.login-btn');
const closeBtn = document.querySelector('.close');
 document.addEventListener("DOMContentLoaded", () => {
  const horarios = {
    cayala: ["13:25", "16:10"],
    miraflores: ["14:25", "17:25"],
    oakland: ["14:05"]
  };

  const complejoSelect = document.getElementById("complejo");
  const resultados = document.querySelector(".horarios-resultados");

  function mostrarHorarios() {
    const complejo = complejoSelect.value;
    const funciones = horarios[complejo] || [];

    resultados.innerHTML = "";

    const contenedor = document.createElement("div");
    contenedor.classList.add("horario-complejo");

    const titulo = document.createElement("h3");
    titulo.textContent = `Horarios disponibles en ${complejoSelect.options[complejoSelect.selectedIndex].text}`;
    contenedor.appendChild(titulo);

    const botones = document.createElement("div");
    botones.classList.add("horario-botones");

    funciones.forEach(hora => {
      const btn = document.createElement("button");
      btn.textContent = hora;
      botones.appendChild(btn);
    });

    contenedor.appendChild(botones);
    resultados.appendChild(contenedor);
  }

  complejoSelect.addEventListener("change", mostrarHorarios);
  mostrarHorarios(); // Mostrar al cargar
});
