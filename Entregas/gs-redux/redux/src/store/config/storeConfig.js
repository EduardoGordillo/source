import { createStore } from "redux"
import { rootReducer } from "../reducer/rootReducer"
import {composeWithDevTools} from 'redux-devtools-extension'

// createAppStore when is called create a new configuration of store, and it can take any name less createStore
export const createAppStore = ()=>{
    let store = createStore(rootReducer, composeWithDevTools())

    return store;
}