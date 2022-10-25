import checkComplete from './components/checkComplete.js';
import deleteIcon from './components/deleteIcon.js';

const btn = document.querySelector('[data-form-btn]'); // Entrar al boton en el dom por medio de dataAtributte, su forma es "data-a-tu-consideracion" obligatorio empezar por data y lo demas es la referencia al objeto al cual se quiere acceder

const createTask = (evento) => {
  evento.preventDefault();
  const input = document.querySelector('[data-form-input]');// siempre que se use query selector es para regersar el contenido del dom, las cuales tiene algunas propiedades que se acceden como objeto normal
  const value = input.value;
  const list = document.querySelector('[data-list]');
  const task = document.createElement('li');
  task.classList.add('card');
  input.value = '';
  
  const taskContent = document.createElement('div');

  const titleTask = document.createElement('span');
  titleTask.classList.add('task');
  titleTask.innerText = value;
  taskContent.appendChild(checkComplete());
  taskContent.appendChild(titleTask);
  // task.innerHTML = content;

  task.appendChild(taskContent);
  task.appendChild(deleteIcon());
  list.appendChild(task);
};

btn.addEventListener('click', createTask);// El listener es para cuando el usuario haga cierta accion dentro de pagina, este responda a ese estimulo en particular. addEventListener(accion a escuchar, que hacer cuando escuche el estimulo)
