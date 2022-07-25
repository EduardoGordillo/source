function inicializarMapa(){
    let mapa = new google.maps.Map(document.getElementById('mapaUbicacionEvento'),{
        zoom: 15,
        center: {lat:19.30928780136658,   lng:-98.86012887301152}

    });
    let marcador = new google.maps.Marker({
        map: mapa,
        draggable: true,
        animation: google.maps.Animation.DROP,
        position: {lat:19.30928780136658,   lng:-98.86012887301152}


    });
    marcador.addListener('click', ()=>{
        ventanaInformacion.open(mapa, marcador);
    });

    let ventanaInformacion = new google.maps.InfoWindow({
        content: 'El evento se realizara en México'
    });

    ventanaInformacion.open(mapa, marcador);

}
window.addEventListener('load', ()=>{
    const scriptMapa = document.createElement('script');
    const llaveApi = 'AIzaSyC5H_zfm3T7emOMGL2IigbvvZjOb_3dVaw';
    scriptMapa.src = `https://maps.googleapis.com/maps/api/js?key=${llaveApi}&callback=inicializarMapa`;
    document.body.appendChild(scriptMapa);
})