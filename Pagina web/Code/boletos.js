document.addEventListener("DOMContentLoaded", () => {
  const categorias = document.querySelectorAll(".categoria");
  const btnContinuar = document.querySelector(".btn-continuar");
  const btnContinuarAsientos = document.querySelector(".btn-continuar-asientos");
  const montoTotal = document.querySelector(".monto-total");
  const seccionBoletos = document.querySelector(".seleccion-boletos");
  const seccionAsientos = document.querySelector(".seleccion-asientos");
  const seccionPago = document.querySelector(".seleccion-pago");
  const pasos = document.querySelectorAll(".paso");

  const mapa = document.getElementById("mapaAsientos");
  const lista = document.getElementById("listaAsientos");
  const contador = document.getElementById("contador");
  const maximo = document.getElementById("maximo");
  const complejoSelect = document.getElementById("complejo");
  const peliculaSelect = document.getElementById("pelicula");
  let totalBoletos = 0;
  let totalPrecio = 0;
  let seleccionados = [];
  let boletosPorTipo = [];
  let peliculaActual = null;

  const cartelera = {
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

  complejoSelect.addEventListener("change", () => {
    const complejo = complejoSelect.value;
    peliculaSelect.innerHTML = '<option value="">Selecciona una película</option>';
    peliculaSelect.disabled = true;

    if (cartelera[complejo]) {
      cartelera[complejo].forEach((pelicula, index) => {
        const option = document.createElement("option");
        option.value = index;
        option.textContent = pelicula.nombre;
        peliculaSelect.appendChild(option);
      });
      peliculaSelect.disabled = false;
    }
  });

  peliculaSelect.addEventListener("change", () => {
    const complejo = complejoSelect.value;
    const index = peliculaSelect.value;
    if (cartelera[complejo] && cartelera[complejo][index]) {
      peliculaActual = cartelera[complejo][index];
      actualizarResumenFinal();
    }
  });

  function actualizarResumenBoletos() {
    totalBoletos = 0;
    totalPrecio = 0;
    boletosPorTipo = [];

    categorias.forEach(categoria => {
      const tipo = categoria.dataset.tipo;
      const precio = parseFloat(categoria.dataset.precio);
      const cantidad = parseInt(categoria.querySelector("input").value) || 0;

      totalBoletos += cantidad;
      totalPrecio += cantidad * (precio + 5);

      for (let i = 0; i < cantidad; i++) {
        boletosPorTipo.push(tipo);
      }
    });

    maximo.textContent = totalBoletos;
    montoTotal.textContent = `Q${totalPrecio}`;
    btnContinuar.disabled = totalBoletos === 0;
  }

  categorias.forEach(categoria => {
    const btnMas = categoria.querySelector(".mas");
    const btnMenos = categoria.querySelector(".menos");
    const input = categoria.querySelector("input");

    btnMas.addEventListener("click", () => {
      let valor = parseInt(input.value) || 0;
      if (totalBoletos < 10) {
        input.value = valor + 1;
        actualizarResumenBoletos();
      }
    });

    btnMenos.addEventListener("click", () => {
      let valor = parseInt(input.value) || 0;
      if (valor > 0) {
        input.value = valor - 1;
        actualizarResumenBoletos();
      }
    });
  });

  btnContinuar.addEventListener("click", () => {
    seccionBoletos.style.display = "none";
    seccionAsientos.style.display = "block";
    pasos[0].classList.remove("activo");
    pasos[1].classList.add("activo");
    generarAsientos();
  });

  function generarAsientos() {
    mapa.innerHTML = "";
    const filas = "ABCDEFG";
    const columnas = 5;

    for (let f = 0; f < filas.length; f++) {
      for (let c = 1; c <= columnas; c++) {
        const id = `${filas[f]}${c}`;
        const asiento = document.createElement("div");
        asiento.classList.add("asiento");
        asiento.textContent = id;
        asiento.title = id;

        asiento.addEventListener("click", () => {
          if (asiento.classList.contains("ocupado")) return;

          const yaSeleccionado = seleccionados.find(a => a.id === id);

          if (yaSeleccionado) {
            asiento.classList.remove("seleccionado");
            seleccionados = seleccionados.filter(a => a.id !== id);
          } else {
            if (seleccionados.length >= totalBoletos) return;
            asiento.classList.add("seleccionado");
            seleccionados.push({ id });
          }

          actualizarResumenAsientos();
        });

        mapa.appendChild(asiento);
      }
    }
  }

  function actualizarResumenAsientos() {
    contador.textContent = seleccionados.length;
    lista.innerHTML = "";

    seleccionados.forEach(({ id }) => {
      const li = document.createElement("li");
      li.textContent = `Asiento ${id}`;
      lista.appendChild(li);
    });

    btnContinuarAsientos.disabled = seleccionados.length !== totalBoletos;
    actualizarResumenFinal();
  }

  function actualizarResumenFinal() {
    const resumenFinal = document.querySelector(".lista-asientos-final");
    const poster = document.querySelector(".poster-pelicula");
    const info = document.querySelector(".info-pelicula");

    if (!resumenFinal || !poster || !info) return;

    resumenFinal.innerHTML = "";

    if (peliculaActual) {
      poster.src = peliculaActual.imagen;
      info.innerHTML = `
        <p><strong>Película:</strong> ${peliculaActual.nombre}</p>
        <p><strong>Duración:</strong> ${peliculaActual.duracion}</p>
        <p><strong>Clasificación:</strong> ${peliculaActual.clasificacion}</p>
        <p><strong>Complejo:</strong> ${complejoSelect.value}</p>
      `;
    }

    if (seleccionados.length > 0) {
      const titulo = document.createElement("p");
      titulo.innerHTML = `<strong>Asientos seleccionados:</strong>`;
      resumenFinal.appendChild(titulo);

      const contenedor = document.createElement("div");
      seleccionados.forEach(({ id }) => {
        const asiento = document.createElement("p");
        asiento.textContent = id;
        contenedor.appendChild(asiento);
      });

      resumenFinal.appendChild(contenedor);
    } else {
      resumenFinal.innerHTML += "<p>No se han seleccionado asientos.</p>";
    }
  }

  // Mostrar/ocultar datos de facturación según selección
  const facturaRadios = document.querySelectorAll('input[name="factura"]');
  const datosFacturaDiv = document.querySelector(".datos-factura");
  facturaRadios.forEach(radio => {
    radio.addEventListener("change", function () {
      if (this.value === "datos") {
        datosFacturaDiv.style.display = "block";
        datosFacturaDiv.querySelectorAll("input").forEach(input => input.required = true);
      } else {
        datosFacturaDiv.style.display = "none";
        datosFacturaDiv.querySelectorAll("input").forEach(input => input.required = false);
      }
    });
  });

  // ARREGLO: Usa addEventListener y elimina cualquier otro submit handler duplicado
  const formularioPago = document.querySelector(".formulario-pago");
  if (formularioPago) {
    formularioPago.addEventListener("submit", function (e) {
      e.preventDefault();

      // Captura de datos del formulario
      const nombres = this.nombres.value.trim();
      const apellidos = this.apellidos.value.trim();
      const correo = this.correo.value.trim();
      const tipoFactura = this.querySelector('input[name="factura"]:checked').value;
      let razonSocial = "";
      let nit = "";

      if (tipoFactura === "datos") {
        razonSocial = this.razon.value.trim();
        nit = this.nit.value.trim();
        if (!razonSocial || !nit) {
          alert("Por favor ingresa Nombre o Razón Social y NIT.");
          return;
        }
      } else {
        razonSocial = nombres + " " + apellidos;
        nit = "CF";
      }

      // Fecha actual
      const fecha = new Date().toLocaleDateString("es-GT", {
        year: "numeric",
        month: "long",
        day: "numeric"
      });

      // Mostrar datos en la factura
      document.getElementById("fechaFactura").textContent = fecha;
      document.getElementById("nombreCliente").textContent = razonSocial;
      document.getElementById("apellidoCliente").textContent = ""; // Ya va en nombreCliente
      document.getElementById("correoCliente").textContent = correo;
      document.getElementById("nitCliente").textContent = nit;

      // Mostrar boletos comprados en tabla
      const tablaBoletos = document.getElementById("tablaBoletosFactura");
      if (tablaBoletos) tablaBoletos.innerHTML = "";
      const tipos = {};

      boletosPorTipo.forEach(tipo => {
        tipos[tipo] = (tipos[tipo] || 0) + 1;
      });

      Object.entries(tipos).forEach(([tipo, cantidad]) => {
        const precio = parseFloat(document.querySelector(`.categoria[data-tipo="${tipo}"]`).dataset.precio);
        const total = cantidad * (precio + 5);
        if (tablaBoletos) {
          const tr = document.createElement("tr");
          tr.innerHTML = `<td>${cantidad}</td><td>${tipo}</td><td>Q${total}</td>`;
          tablaBoletos.appendChild(tr);
        }
      });

      document.getElementById("totalFactura").textContent = `Q${totalPrecio}`;

      // Mostrar factura y ocultar formulario
      document.querySelector(".seleccion-pago").style.display = "none";
      document.querySelector(".factura").style.display = "block";

      // Descargar factura como PDF y redirigir al inicio
      setTimeout(() => {
        window.print();
        window.location.href = "./vista clientes.html";
      }, 500);
    });
  }

  btnContinuarAsientos.addEventListener("click", () => {
    if (seleccionados.length !== totalBoletos) return;

    seccionAsientos.style.display = "none";
    seccionPago.style.display = "block";
    pasos[1].classList.remove("activo");
    pasos[2].classList.add("activo");

    actualizarResumenFinal();
  });

  actualizarResumenBoletos();
});