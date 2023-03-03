import { combineReducers } from "redux";
import { filterReducer } from "./filterReducer";
import { todosReducer } from "./todosReducer";
import { userReducer } from "./userReducer";


export const rootReducer = combineReducers(
    {

        //stateName: Reducer that will control it
        todosState: todosReducer,
        filterState : filterReducer,

        userState: userReducer
    }

)