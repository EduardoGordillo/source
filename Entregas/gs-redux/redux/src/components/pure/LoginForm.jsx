import { ErrorMessage, Field, Form, Formik } from 'formik';
import React from 'react';
import { useHistory } from 'react-router-dom';
import * as Yup from 'yup'
import { Redirect } from 'react-router-dom';
import PropTypes from 'prop-types';
const loginSchema = Yup.object().shape({
    email: Yup.string().email('Ivalid email format')
        .required('Email is required'),
    password: Yup.string().required('Password is required')
});

const LoginForm = ({logged, onLogin}) => {

   
    return (
        <div>
            <h4>LogIn Form</h4>
            <Formik
                initialValues={{

                    email: "",
                    password: ""

                }}

                validationSchema={loginSchema}

                onSubmit={
                    async (value) => {
                        onLogin(value.email, value.password)
                    }
                }
            >
                {props => {
                    const {
                        values,
                        touched,
                        errors,
                        isSubmitting,
                        handleChange,
                        handleBlur,
                        handleSubmit
                    } = props;
                    return (<Form>
                        <label htmlFor="email">Email</label>
                        <Field id="email" name="email" placeholder="example@domain.com" type='email' />
                        {
                            errors.email && touched.email && (
                                <div className="error">
                                    <p>{errors.email}</p>
                                </div>
                            )
                        }
                        <label htmlFor="password">Password</label>
                        <Field id="password" type='password' name="password" placeholder="Password" />
                        {
                            errors.password && touched.password && (
                                
                                    <ErrorMessage name='password' component='div'> </ErrorMessage>
                                )
                        }
                        
                        <button type="submit">Submit</button>
                        {isSubmitting? 'Your credentials are subtmitting' : null}
                    </Form>)
                }}


            </Formik>
        </div>
    );
}
LoginForm.propTypes = {
    logged: PropTypes.bool.isRequired,
    onLogin: PropTypes.func.isRequired,

};

export default LoginForm;
