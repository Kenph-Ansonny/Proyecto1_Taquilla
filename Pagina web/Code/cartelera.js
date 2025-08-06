const peliculas = {
  "Cinépolis Cayalá": [
    {
      nombre: "Intensamente 2",
      duracion: "117 min",
      clasificacion: "A",
      doblada: "15:15, 20:30, 20:40",
      subtitulada: "18:00, 19:00, 21:45",
      imagen: "https://preview.redd.it/official-poster-for-inside-out-2-v0-kydd292s1ymc1.jpeg?auto=webp&s=1883bc3b14150de4d41c16880f8509b0c64c0f52",
      enlace: "./Intensamente.html"
    },
    {
      nombre: "Cómo entrenar a tu dragón",
      duracion: "126 min",
      clasificacion: "A",
      doblada: "13:25, 16:10",
      subtitulada: "",
      imagen: "https://www.informador.mx/__export/1739397082528/sites/elinformador/img/2025/02/12/cxmo_entrenar_a_a_tu_dragxn_poster.jpg_524400468.jpg",
      enlace: "./Como entrenar a tu dragon.html"
    },
    {
      nombre: "Jurassic World: Renace",
      duracion: "134 min",
      clasificacion: "B",
      doblada: "13:45",
      subtitulada: "16:50",
      imagen: "https://image.tmdb.org/t/p/original/q0fGCmjLu42MPlSO9OYWpI5w86I.jpg",
      enlace: "./Jurassic Park.html"
    },

      {
      nombre: "Superman",
      duracion: "130 min",
      clasificacion: "B",
      doblada: "13:45",
      subtitulada: "19:15",
      imagen: "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRU2j0Hgm1zjsN8SbAh_ZKPz-RoynuZdhSmgA&s",
      enlace: "./Superman.html"
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
      <img src="${p.imagen}" alt="${p.nombre}" />
      <div class="pelicula-info">
        <h3>${p.nombre} <span class="clasificacion">${p.clasificacion}</span></h3>
        <p><strong>Duración:</strong> ${p.duracion}</p>
        <div class="horarios">
          <strong>Doblada:</strong> ${p.doblada || '—'}<br>
          <strong>Subtitulada:</strong> ${p.subtitulada || '—'}
        </div>
        <a href="${p.enlace || '#'}" class="trailer-btn">▶️ Ver tráiler</a>

      </div>
    `;
    lista.appendChild(card);
  });
}

renderCartelera("Cinépolis Cayalá");
