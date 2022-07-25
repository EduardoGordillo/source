import React, { useEffect, useState } from "react";
import { Text, TextInput, StyleSheet, TouchableOpacity } from "react-native-web";
import Layout from "../components/Layout";
import { saveTask, getTask, updateTask } from "../api";

const TaskFormScreen = ({ navigation, route }) => {

    const [task, setTask] = useState({
        title: '',
        description: '',
    });
    const [editing, setEditing] = useState(false);

    const handleChange = (name, value) => {
        setTask({ ...task, [name]: value });
    }

    const handleSubmit = async () => {
        try {
            if (!editing) {
                await saveTask(task);

            } else {
                await updateTask(route.params.id, task)
            }
            navigation.navigate('Homescreen');
        }
        catch (e) {
            console.log(e);
        }
    }

    useEffect(() => {
        if (route.params && route.params.id) {
            navigation.setOptions({ headerTitle: 'Update a Task' });
            setEditing(true);
            (async () => {
                const res = await getTask(route.params.id)
                setTask({ title: res.title, description: res.description })
                    ;
            })();
        }
    }, []);

    return (
        <Layout>
            <TextInput
                style={styles.input}
                placeholder="Write  Title"
                placeholderTextColor="546574"
                onChangeText={(text) => { handleChange('title', text) }}
                value={task.title}
            />
            <TextInput
                style={styles.input}
                placeholder="Write Description"
                placeholderTextColor="566574"
                onChangeText={(text) => { handleChange('description', text) }}
                value={task.description}
            />

            {
                !editing ? (
                    <TouchableOpacity style={styles.buttonSafe} onPress={handleSubmit} >
                        <Text style={styles.buttonText}>Save Task</Text>
                    </TouchableOpacity>
                ) : (<TouchableOpacity style={styles.buttonUpdate} onPress={handleSubmit} >
                    <Text style={styles.buttonText}>Update Task</Text>
                </TouchableOpacity>
                )
            }

        </Layout>
    );
};

const styles = StyleSheet.create({
    input: {
        width: '90%',
        marginBotton: 7,
        borderWidth: 1,
        fontSize: 14,
        borderColor: '#10ac84',
        height: 35,
        color: '#ffffff',
        textAlign: 'center',
        padding: 4,
        borderRadius: 5,

    },
    buttonSafe: {
        paddingTop: 10,
        paddingBottom: 10,
        borderRadius: 5,
        marginBottom: 10,
        backgroundColor: '#10ac84',
        width: '90%',

    },
    buttonText: {
        color: '#FFFFFF',
        textAlign: 'center',

    },

    buttonUpdate:{
        paddingTop: 10,
        paddingBottom: 10,
        borderRadius: 5,
        marginBottom: 10,
        backgroundColor: '#BECF1E',
        width: '90%',
    }


});

export default TaskFormScreen