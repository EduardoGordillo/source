import React, { useReducer, useRef, useState } from 'react';
const ADD_TODO = 'ADD_TODO';
const DELETE_TODO = 'DELETE_TODO';
const FILTRO_TODO = 'FILTRO_TODO';

const myContext = React.createContext(null)
const TODOs = () => {
    const [id, setid] = useState(0);
    const initialState = []
    let stateCopy;
    const reducer = (state, action)=>{
        switch (action.type) {
            
            case ADD_TODO:
                setid(id+1)
                return [
                    ...state,
                    {
                        id: id,
                        text: action.payload.text,
                        complete: false
                     
                    }

                ]
            case DELETE_TODO:
                return state.filter((x) => x.id !== action.payload.id);
            case FILTRO_TODO :
                stateCopy = [...state]
                switch (action.payload.type) {
                    case 'SHOW_ALL':
                        return state
                    case 'Complete':
                        
                        return stateCopy.filter((task)=> task.complete)
                        
                
                    
                    case 'Incomplete':
                        
                        return stateCopy.filter((task)=> !task.complete)
                        
                
                    default:
                        return state;
                }
        
            default:
                return state;
        }
    }
    const textRef = useRef('');
  

    function addTask(e){
        e.preventDefault();
        dispatch({type: ADD_TODO,
        payload: {

            text: textRef.current.value
            


        }})
    }
    function deleteTask(id){
        
        
        dispatch({
            type: DELETE_TODO,
            payload:{
                id
            }
        })
        
        


    }
    const [state, dispatch] = useReducer(reducer, initialState)
    return (
       <myContext.Provider value={state}>
        <div>
            {state.map((task, index) =>(<div key={index}><h1 >{task.text}</h1>
            <i onClick={()=>deleteTask(task.id)}>Borrar</i></div>))}

            <form onSubmit={addTask}>
                <input ref={textRef}></input>
                <button>AddTask</button>
            </form>

            <button onClick={()=>{
                dispatch({
                    type: FILTRO_TODO,
                    payload:{
                        type: 'Complete'
                    }
                })
            }}>Show Complete</button>
            <button onClick={()=>{
                dispatch({
                    type: FILTRO_TODO,
                    payload:{
                        type: 'Incomplete'
                    }
                })
            }}>Show Incomplete</button>
            <button onClick={()=>{
                dispatch({
                    type: FILTRO_TODO,
                    payload:{
                        type: 'SHOW_ALL'
                    }
                })
            }}>Show ALL</button>
            
        </div>
       </myContext.Provider>
    );
}

export default TODOs;
