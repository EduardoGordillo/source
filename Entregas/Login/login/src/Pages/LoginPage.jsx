import React from 'react';
import { useHistory } from 'react-router-dom';

const LoginPage = ({log}) => {
    const history = useHistory();
    const register = ()=>{
        history.push('/register')
    }
    const login = ()=>{
        log(true);
        history.push('/')
    }
    return (
        <div>
            <h1>Loggin Page </h1>
            <button onClick={register}>Register</button>
            <button onClick={login}>Log In</button>
        </div>
    );
}

export default LoginPage;
