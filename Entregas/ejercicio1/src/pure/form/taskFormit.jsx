import { Formik, Field, Form, ErrorMessage} from 'formik';
import React from 'react';
import { levels } from '../../../models/levels.enum';
import { Task } from '../../../models/task.class';
import * as Yup from 'yup';

const TaskFormit = ({ add }) => {

    const initialValues = {
        name: '',
        description: '',
        picked: levels.NORMAL
    };

    const onSubmit = (values) => {

        const task = new Task(values.name, values.description, false, values.picked);
        add(task);

    }
    const validationSchemas = Yup.object().shape(
        {
            name: Yup.string().required('Field is required'),
            description: Yup.string().required('Field is required')
        }
    )

    return (
        <div>
            <h3>
                Add Task
            </h3>
            <Formik
                initialValues={initialValues}
                validationSchema={validationSchemas}
                onSubmit={onSubmit}
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
                        <label htmlFor="name">Name</label>
                        <Field id="name" name="name" placeholder="Name of Task" />
                        {
                            errors.name && touched.name && (
                                
                                    <ErrorMessage name='name' component='div'> </ErrorMessage>
                                )
                        }

                        <label htmlFor="description">Description</label>
                        <Field id="description" name="description" placeholder="Some description" />
                        {
                            errors.description && touched.description && (
                                    <ErrorMessage name='description' component='div'> </ErrorMessage>
                            )
                        }

                        <div id="my-radio-group">Picked</div>
                        <div role="group" aria-labelledby="my-radio-group">
                            <label>
                                <Field type="radio" name="picked" value={levels.NORMAL} />
                                Normal
                            </label>
                            <label>
                                <Field type="radio" name="picked" value={levels.URGENT} />
                                Urgent
                            </label>
                            <label>
                                <Field type="radio" name="picked" value={levels.BLOCKING} />
                                Blocking
                            </label>
                           
                        </div>


                        <button type="submit">Submit</button>
                        {isSubmitting ? 'Your credentials are subtmitting' : null}
                    </Form>)
                }}
            </Formik>
        </div>
    );
}

export default TaskFormit;
