import { compose, createStore, applyMiddleware } from "redux"
import { rootReducer } from "../reducer/rootReducer"
import {composeWithDevTools} from 'redux-devtools-extension'
import { whatcherSaga } from "../sagas/sagas"
import createSagaMiddleware from "@redux-saga/core"

// createAppStore when is called create a new configuration of store, and it can take any name less createStore
export const createAppStore = ()=>{
    let store = createStore(rootReducer, composeWithDevTools())

    return store;
}
export const asyncAppStore =() => {
    const sagaMiddleware = createSagaMiddleware()
    let store = createStore(rootReducer,compose(applyMiddleware(sagaMiddleware), composeWithDevTools()))

    sagaMiddleware.run(whatcherSaga)
    return store;

}   