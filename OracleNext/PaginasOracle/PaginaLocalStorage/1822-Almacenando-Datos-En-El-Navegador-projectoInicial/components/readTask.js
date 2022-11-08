import { createTask } from "./addTask.js";
import dateElement from "./dateElement.js";
import { uniqueDates } from "../services/date.js";
export const displayTask = ()=>{
    
    const list = document.querySelector('[data-list]')
    const taskList = JSON.parse(localStorage.getItem('Task')) || [];

    const dates = uniqueDates(taskList);
    dates.forEach( date =>{
        list.appendChild(dateElement(date))
        const dateMoment = moment(date, 'DD/MM/YYYY');
        
        taskList.forEach((task) => {
           
            const taskDate = moment(task.dateFormat, 'DD/MM/YYYY');
            const diff = dateMoment.diff(taskDate);
            if(diff === 0)
            list.appendChild(createTask(task));
    
        });
    });
   

    
}