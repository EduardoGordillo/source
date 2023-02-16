import React from 'react';
import { useHistory } from 'react-router-dom';

const RegisterPage = ({log}) => {
    const history = useHistory();
    const loggin = ()=>{
        history.push('/loggin')
    }
    const register = ()=>{
        log(true)
        history.push('/')
    }
    return (
        <div>
            <h1>Register Page</h1>
            <button onClick={loggin}>Log In</button>
            <button onClick={register}>Register</button>
        </div>
    );
}

export default RegisterPage;
