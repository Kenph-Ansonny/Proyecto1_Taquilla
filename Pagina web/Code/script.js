// 🎬 Películas destacadas para el carrusel
const estrenos = [
  {
    nombre: "Superman",
    imagen: "Sources/superman.jpg",
    mensaje: "🎟️ Preventa: Superman"
  },
  {
    nombre: "Jurassic World Renace",
    imagen: "Sources/jurassic.jpg",
    mensaje: "🎬 Próximo estreno: Jurassic World Renace"
  },
  {
    nombre: "Pitufos",
    imagen: "Sources/pitufos.jpg",
    mensaje: "🌀 Próximo estreno: Pitufos"
  }
];

// 📽️ Renderiza el carrusel
document.addEventListener('DOMContentLoaded', () => {
  const track = document.getElementById('carrousel-track');

  estrenos.forEach(e => {
    const item = document.createElement('div');
    item.className = 'carrousel-item';
    item.innerHTML = `
      <img src="${e.imagen}" alt="${e.nombre}" onerror="this.src='https://via.placeholder.com/800x400?text=Imagen+no+disponible'">
      <div class="carrousel-caption">${e.mensaje}</div>
    `;
    track.appendChild(item);
  });

  // Clona el primer elemento para efecto de bucle
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
});

// 🗂️ Películas en cartelera
const peliculasCartelera = [
  {
    nombre: "Deadpool",
    imagen: "https://mir-s3-cdn-cf.behance.net/project_modules/max_1200/02cc1333658190.56b2c8ea3720a.png"
  },
  {
    nombre: "Intensamente 2",
    imagen: "https://preview.redd.it/official-poster-for-inside-out-2-v0-kydd292s1ymc1.jpeg?auto=webp&s=1883bc3b14150de4d41c16880f8509b0c64c0f52"
  },
  {
    nombre: "Jurassic World Renace",
    imagen: "https://image.tmdb.org/t/p/original/q0fGCmjLu42MPlSO9OYWpI5w86I.jpg"
  },
  {
    nombre: "Spider-Man: Sin Camino a Casa",
    imagen: "https://pics.filmaffinity.com/spider_man_no_way_home-642739124-large.jpg"
  },
  {
    nombre: "Avengers: Infinity War",
    imagen: "https://cdn.flickeringmyth.com/wp-content/uploads/2018/04/Avengers-Infinity-War-posters-56-2.jpg"
  },
  {
    nombre: "Los Guardinaes de la Galaxia",
    imagen: "https://pics.filmaffinity.com/guardians_of_the_galaxy-595487268-large.jpg"
  },
  {
    nombre: "Cómo entrenar a tu dragón",
    imagen: "https://www.informador.mx/__export/1739397082528/sites/elinformador/img/2025/02/12/cxmo_entrenar_a_a_tu_dragxn_poster.jpg_524400468.jpg"
  },
  {
    nombre: "Destino Final",
    imagen: "https://pics.filmaffinity.com/final_destination_bloodlines-790034090-large.jpg"
  },
];

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
      <div class="pelicula-overlay">
        <img class="pelicula-img" src="${p.imagen}" alt="${p.nombre}">
        <div class="pelicula-actions">
          <a href="./sinopsis.html?pelicula=${encodeURIComponent(p.nombre)}" class="btn-sinopsis">📖 Ver sinopsis</a>
          <a href="./boletos.html?pelicula=${encodeURIComponent(p.nombre)}" class="btn-boletos">🎟️ Comprar boletos</a>
        </div>
      </div>
    `;
    grid.appendChild(card);
  });
}

// 🎚️ Filtrado por región y categoría
function aplicarFiltros() {
  const region = document.getElementById('filtroRegion').value;
  const categoria = document.getElementById('filtroCine').value;
  const filtradas = peliculasCartelera.filter(p => {
    return (region === "" || p.region === region) &&
           (cine === "" || p.cine === cine);
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
document.getElementById('filtroCine').addEventListener('change', aplicarFiltros);

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

 document.getElementById("loginForm").addEventListener("submit", async (e) => {
  e.preventDefault();

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

    const data = await response.json();

    if (response.ok) {
      alert(`✅ ${data.mensaje}`);
      
      window.location.href="./cartelera.html"
    } else {
      alert("❌ Error: " + (data.error || "No autorizado"));
    }

  } catch (error) {
    console.error("Error al intentar iniciar sesión:", error);
    alert("🚫 Error de red o servidor no disponible");
  }
});
