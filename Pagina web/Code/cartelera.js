const peliculas = {
  "Cinépolis Cayalá": [
    {
      nombre: "Intensamente 2",
      duracion: "117 min",
      clasificacion: "A",
      imagen: "https://preview.redd.it/official-poster-for-inside-out-2-v0-kydd292s1ymc1.jpeg?auto=webp&s=1883bc3b14150de4d41c16880f8509b0c64c0f52",
      enlace: "./intensamente.html",
      trailer: "Videos/IntensaMente 2 _ Tráiler Oficial _ Doblado con subtítulos descriptivos.mp4"
    },
    {
      nombre: "Cómo entrenar a tu dragón",
      duracion: "126 min",
      clasificacion: "A",
      imagen: "https://www.informador.mx/__export/1739397082528/sites/elinformador/img/2025/02/12/cxmo_entrenar_a_a_tu_dragxn_poster.jpg_524400468.jpg",
      enlace: "./como entrenar a tu dragon.html",
      trailer: "Videos/CÓMO ENTRENAR A TU DRAGÓN Tráiler 2 Español Latino (2025)(2).mp4"
    },
    {
      nombre: "Jurassic World: Renace",
      duracion: "134 min",
      clasificacion: "B",
      imagen: "https://image.tmdb.org/t/p/original/q0fGCmjLu42MPlSO9OYWpI5w86I.jpg",
      enlace: "./jurassic park.html",
      trailer: "Videos/Jurassic World Renace Tráiler Oficial – HD.mp4"
    },
    {
      nombre: "Superman (2025)",
      duracion: "129 min",
      clasificacion: "B",
      imagen: "Sources/superman2.jpg",
      enlace: "./superman.html",
      trailer: "Videos/SUPERMAN Tráiler Español Latino (2025).mp4"
    }
  ],
  "Cinépolis Portales": [
    {
      nombre: "Spider-Man: Sin Camino a Casa",
      duracion: "148 min",
      clasificacion: "B",
      imagen: "https://pics.filmaffinity.com/spider_man_no_way_home-642739124-large.jpg",
      enlace: "./spiderman.html",
      trailer: "Videos/SpiderMan_NoWayHome_Trailer.mp4"
    },
    {
      nombre: "Destino Final",
      duracion: "110 min",
      clasificacion: "C",
      imagen: "https://pics.filmaffinity.com/final_destination_bloodlines-790034090-large.jpg",
      enlace: "./destino-final.html",
      trailer: "Videos/DestinoFinal_Trailer.mp4"
    }
  ],
  "Cinépolis Oakland Mall": [
    {
      nombre: "Jurassic World: Renace",
      duracion: "134 min",
      clasificacion: "B",
      imagen: "https://image.tmdb.org/t/p/original/q0fGCmjLu42MPlSO9OYWpI5w86I.jpg",
      enlace: "./jurassic park.html",
      trailer: "Videos/Jurassic World Renace Tráiler Oficial – HD.mp4"
    },
    {
      nombre: "Los Guardianes de la Galaxia",
      duracion: "136 min",
      clasificacion: "B",
      imagen: "https://pics.filmaffinity.com/guardians_of_the_galaxy-595487268-large.jpg",
      enlace: "./guardianes.html",
      trailer: "Videos/Guardianes_Trailer.mp4"
    }
  ],
  "Cinépolis El Frutal": [
    {
      nombre: "Superman (2025)",
      duracion: "129 min",
      clasificacion: "B",
      imagen: "Sources/superman2.jpg",
      enlace: "./superman.html",
      trailer: "Videos/SUPERMAN Tráiler Español Latino (2025).mp4"
    },
    {
      nombre: "Avengers: Infinity War",
      duracion: "149 min",
      clasificacion: "B",
      imagen: "https://cdn.flickeringmyth.com/wp-content/uploads/2018/04/Avengers-Infinity-War-posters-56-2.jpg",
      enlace: "./avengers.html",
      trailer: "Videos/Avengers_Trailer.mp4"
    }
  ]
};

function renderCartelera(complejo) {
  const titulo = document.getElementById('tituloComplejo');
  const lista = document.getElementById('peliculasLista');

  titulo.textContent = `Cartelera - ${complejo}`;
  lista.innerHTML = '';

  const cartelera = peliculas[complejo] || [];

  cartelera.forEach(p => {
    const card = document.createElement('div');
    card.className = 'pelicula';

    card.innerHTML = `
      <a href="${p.enlace}">
        <img src="${p.imagen}" alt="${p.nombre}" />
      </a>
      <div class="pelicula-info">
        <h3>${p.nombre} <span class="clasificacion">${p.clasificacion}</span></h3>
        <p><strong>Duración:</strong> ${p.duracion}</p>
        <button class="trailer-btn" data-trailer="${p.trailer}">▶️ Ver tráiler</button>
      </div>
    `;

    const btn = card.querySelector('.trailer-btn');
    btn.addEventListener('click', function(e) {
      e.preventDefault();
      e.stopPropagation();
      abrirModal(this.getAttribute('data-trailer'));
    });

    lista.appendChild(card);
  });
}

function abrirModal(trailerSrc) {
  const modal = document.getElementById('modalTrailer');
  const video = document.getElementById('videoTrailer');

  video.src = trailerSrc;
  modal.style.display = 'flex';

  // Cerrar el modal cuando el cursor salga del video
  video.addEventListener('mouseleave', cerrarModal);
}

function cerrarModal() {
  const modal = document.getElementById('modalTrailer');
  const video = document.getElementById('videoTrailer');

  video.pause();
  video.src = '';
  modal.style.display = 'none';

  // Evitar múltiples listeners
  video.removeEventListener('mouseleave', cerrarModal);
}


// Render inicial
renderCartelera('Cinépolis Cayalá');
