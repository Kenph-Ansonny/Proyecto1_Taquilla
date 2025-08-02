// 🎬 Películas destacadas para el carrusel
const estrenos = [
  {
    nombre: "Superman",
    imagen: "superman.jpg",
    mensaje: "🎟️ Preventa: Superman"
  },
  {
    nombre: "Jurassic World Renace",
    imagen: "jurassic.jpg",
    mensaje: "🎬 Próximo estreno: Jurassic World Renace"
  },
  {
    nombre: "Pitufos",
    imagen: "pitufos.jpg",
    mensaje: "🌀 Próximo estreno: Pitufos"
  }
];

// 🗂️ Películas en cartelera
const peliculasCartelera = [
  {
    nombre: "Deadpool",
    horario: "7:00 PM",
    region: "Guatemala",
    categoria: "Acción",
    imagen: "https://mir-s3-cdn-cf.behance.net/project_modules/max_1200/02cc1333658190.56b2c8ea3720a.png"
  },
  {
    nombre: "Intensamente 2",
    horario: "5:30 PM",
    region: "Guatemala",
    categoria: "Infantil",
    imagen: "https://preview.redd.it/official-poster-for-inside-out-2-v0-kydd292s1ymc1.jpeg?auto=webp&s=1883bc3b14150de4d41c16880f8509b0c64c0f52"
  },
  {
    nombre: "Jurassic World Renace",
    horario: "6:00 PM",
    region: "Guatemala",
    categoria: "Acción",
    imagen: "https://image.tmdb.org/t/p/original/q0fGCmjLu42MPlSO9OYWpI5w86I.jpg"
  },
  {
    nombre: "Paddington 3",
    horario: "4:00 PM",
    region: "Guatemala",
    categoria: "Infantil",
    imagen: "https://via.placeholder.com/400x260?text=Paddington+3"
  },
  {
    nombre: "Los Becarios",
    horario: "8:30 PM",
    region: "Quetzaltenango",
    categoria: "Comedia",
    imagen: "https://via.placeholder.com/400x260?text=Los+Becarios"
  },
  {
    nombre: "Guardianes Galácticos",
    horario: "6:45 PM",
    region: "Guatemala",
    categoria: "Acción",
    imagen: "https://via.placeholder.com/400x260?text=Guardianes+Galácticos"
  },
  {
    nombre: "La Casa Encantada",
    horario: "7:15 PM",
    region: "Quetzaltenango",
    categoria: "Infantil",
    imagen: "https://via.placeholder.com/400x260?text=La+Casa+Encantada"
  },
  {
    nombre: "Código Final",
    horario: "9:30 PM",
    region: "Quetzaltenango",
    categoria: "Acción",
    imagen: "https://via.placeholder.com/400x260?text=Código+Final"
  },
];

// 📽️ Renderiza el carrusel
const track = document.getElementById('carrousel-track');
estrenos.forEach(e => {
  const item = document.createElement('div');
  item.className = 'carrousel-item';
  item.innerHTML = `
    <img src="${e.imagen}" alt="${e.nombre}">
    <div class="carrousel-caption">${e.mensaje}</div>`;
  track.appendChild(item);
});
const firstClone = track.firstElementChild.cloneNode(true);
track.appendChild(firstClone);

let currentIndex = 0;
const totalItems = track.children.length;

setInterval(() => {
  currentIndex++;
  track.style.transition = 'transform 0.5s ease-in-out';
  track.style.transform = `translateX(-${currentIndex * 100}%)`;

  if (currentIndex === totalItems - 1) {
    setTimeout(() => {
      track.style.transition = 'none';
      track.style.transform = 'translateX(0)';
      currentIndex = 0;
    }, 600);
  }
}, 4000);

// 🎞️ Renderiza las películas en cartelera
function renderPeliculas(filtradas) {
  const grid = document.getElementById('cartelera');
  grid.innerHTML = '';

  if (filtradas.length === 0) {
    grid.innerHTML = '<p style="text-align:center; font-size:1.1em; color:#888;">🎬 No se encontraron películas con esos filtros.</p>';
    return;
  }

  filtradas.forEach(p => {
    const card = document.createElement('div');
    card.className = 'pelicula-card';
    card.innerHTML = `
      <img class="pelicula-img" src="${p.imagen}" alt="${p.nombre}">
      <div class="pelicula-info">
        <h3>${p.nombre}</h3>
        <p><strong>Horario:</strong> ${p.horario}</p>
        <p><strong>Región:</strong> ${p.region}</p>
        <p><strong>Categoría:</strong> ${p.categoria}</p>
        <button>🎟️ Comprar Boletos</button>
      </div>
    `;
    grid.appendChild(card);
  });
}

// 🎚️ Filtrado por región y categoría
function aplicarFiltros() {
  const region = document.getElementById('filtroRegion').value;
  const categoria = document.getElementById('filtroCategoria').value;
  const filtradas = peliculasCartelera.filter(p => {
    return (region === "" || p.region === region) &&
           (categoria === "" || p.categoria === categoria);
  });
  renderPeliculas(filtradas);
}

// 🔎 Buscador por nombre
document.getElementById('buscador').addEventListener('input', function(e) {
  const texto = e.target.value.toLowerCase();
  const filtradas = peliculasCartelera.filter(p => p.nombre.toLowerCase().includes(texto));
  renderPeliculas(filtradas);
});

// 🧩 Listeners para filtros
document.getElementById('filtroRegion').addEventListener('change', aplicarFiltros);
document.getElementById('filtroCategoria').addEventListener('change', aplicarFiltros);

// 🚀 Carga inicial
renderPeliculas(peliculasCartelera);

// 🔐 Modal de login
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

let carrito = [];

function actualizarCarritoUI() {
  const lista = document.getElementById("cart-list");
  const contador = document.getElementById("cart-count");
  const total = document.getElementById("total-items");

  lista.innerHTML = '';
  carrito.forEach((item, i) => {
    const li = document.createElement("li");
    li.style.marginBottom = "10px";
    li.innerHTML = `
      🎬 <strong>${item.nombre}</strong> - ${item.horario} (${item.region}) 
      <button style="margin-left:10px;" onclick="eliminarDelCarrito(${i})">❌</button>`;
    lista.appendChild(li);
  });

  contador.textContent = carrito.length;
  total.textContent = carrito.length;
}

function agregarAlCarrito(pelicula) {
  carrito.push(pelicula);
  actualizarCarritoUI();
}

function eliminarDelCarrito(index) {
  carrito.splice(index, 1);
  actualizarCarritoUI();
}


const modalCarrito = document.getElementById("modalCarrito");
const cartBtn = document.getElementById("cart-btn");
const closeCartBtn = document.querySelector(".close-cart");

cartBtn.addEventListener("click", () => {
  modalCarrito.style.display = "block";
});
closeCartBtn.addEventListener("click", () => {
  modalCarrito.style.display = "none";
});
window.addEventListener("click", e => {
  if (e.target === modalCarrito) modalCarrito.style.display = "none";
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