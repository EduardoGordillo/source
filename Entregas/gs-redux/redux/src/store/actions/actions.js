let nextTodoID = 0;

export const ADD_TODO = 'ADD_TODO';
export const TOGGLE_TODO = 'TOGGLE_TODO';
export const SET_VISIBILITY_FILTER = 'SET_VISIBILITY_FILTER';

/**
 * @param {string} text
 * @return action ADD_TODO
 */
export const addTodo = (text)=>{
    return {
        type: ADD_TODO,
        payload : {
            id: nextTodoID++,
            text
        }
    }
}
/**
 * @param {number} id
 * @return action   TOGGLE_TODO
 */
export const toggleTodo = (id)=>{
    return {
        type: TOGGLE_TODO,
        payload : {
            id
        }
    }
}

/**
 * 
 * @param {filter} filter 
 * @returns action FILTER_TODO
 */
export const setVisibilityFilter = (filter)=>{
    return {
        type : SET_VISIBILITY_FILTER,
        payload : {
            filter
        }
    }
}