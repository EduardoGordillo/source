

/*const http = require('http');
const colors =require('colors')
const handleServer = function(req, res){// req es una peticion y res es una repuesta del servidor 
    res.writeHead(404, {'Content-type': 'text/html'})
    res.write('<h1>Hola Mundo desde</h1>');
    res.write('Esto es un string');
    res.end();
}
const server = http.createServer(handleServer);

server.listen(3000, function(){
    console.log('Server on port 3000'.bgMagenta);
})*/
const colors =require('colors');
const express = require('express');

const server = express();

server.get('/', (req, res)=>{
    res.send('<h1>Hola Mundo con Express y Node</h1>');
    res.end();
})

server.listen(3000,()=>{
    console.log('Server on port 3000') 
});