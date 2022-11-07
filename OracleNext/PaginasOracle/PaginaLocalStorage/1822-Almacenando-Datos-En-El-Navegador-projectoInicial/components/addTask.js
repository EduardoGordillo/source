import checkComplete from './checkComplete.js';
import deleteIcon from './deleteIcon.js';

const addTask = (evento)=>{ 
    evento.preventDefault();
    const list = document.querySelector('[data-list]');
    const taskList = JSON.parse(localStorage.getItem('Task') ) || [];
    const input = document.querySelector('[data-form-input]');
    const calendar = document.querySelector('[data-form-date]');

    const value = input.value;
    const date = calendar.value;
    const dateFormat = moment(date).format('DD/MM/YYYY')

    input.value = '';  
    calendar.value = '';
    if(value === '' || date === ''){
    
      return 'Invalid'
    }
    else{
      taskList.push({value, dateFormat});
      localStorage.setItem('Task', JSON.stringify(taskList));
      
    
      const task = createTask({value, dateFormat});
      list.appendChild(task);
    
    }

    
  }
  
  
  
export const createTask = ({value, dateFormat}) => {
    
   
    const task = document.createElement('li');
    task.classList.add('card');
    
   
    const taskContent = document.createElement('div');
  
    const titleTask = document.createElement('span');
        titleTask.classList.add('task');
        titleTask.innerText = value;
        taskContent.appendChild(checkComplete());
        taskContent.appendChild(titleTask);
    // task.innerHTML = content;
    const dateElement = document.createElement('span');
        dateElement.innerHTML= dateFormat;
        
        task.appendChild(taskContent);
        task.appendChild(dateElement);
        task.appendChild(deleteIcon());
    return task;
  };
  
export default addTask;