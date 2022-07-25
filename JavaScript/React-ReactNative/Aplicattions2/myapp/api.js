const API = 'http://localhost:3000/task'
export const getTasks = async()=> {
    const res = await fetch(API);
    return await res.json();
  
}

export const  getTask = async(id)=> {
    const res = await fetch(`${API}/${id}`);
    return await res.json();
};

export const saveTask = async(newTask)=> {
const rest = await fetch(API, {
    method: 'POST', 
    headers: {Accept: 'application/json', "Content-Type": "application/json"},
    body: JSON.stringify(newTask)

})
return await rest.json();
};

export const deleteTask = async(idTask)=>{
    await fetch(`${API}/${idTask}`, {
        method: 'DELETE',
        
    })
}

export const updateTask = async(idTask, newTask)=>{
    await fetch(`${API}/${idTask}`, { 
        method: 'PUT',
        headers: {Accept: 'application/json', "Content-Type": "application/json"},
        body: JSON.stringify(newTask)
    })
}