import React from 'react'
import { connect } from 'react-redux'
import { httpRequest } from '../../store/actions/asyncActions'
import LoginForm from '../pure/LoginForm'



const mapStateToProps = (state) => {
    return{
        logged: state.userState.logged
    }
}

const mapDispatchToProps = (dispatch)=>{
    return {
        onLogin: (email, password)=>{
            const data = {
                email,
                password
            }
            const url = 'https://reqres.in/api/login'
            dispatch(httpRequest('POST',url, data ))
        }
    }
}

const LoginFormContainer = connect(mapStateToProps, mapDispatchToProps)(LoginForm)
export default LoginFormContainer