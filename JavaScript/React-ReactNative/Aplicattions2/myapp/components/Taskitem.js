import React from "react";
import { View, Text, StyleSheet, TouchableOpacity } from 'react-native';
import { useNavigation } from "@react-navigation/native"; 

const TaskItem = ({ task, handleDeleteTask }) => {
    
    const navigation = useNavigation();

    return (
        <View style={styles.itemContainer}>

            <TouchableOpacity onPress={()=>{navigation.navigate('TaskFormScreen', {id: task.id})}}>
                <Text style={styles.itemTitle}>{task.title}</Text>
                <Text style={styles.itemTitle}>{task.description}</Text>
            </TouchableOpacity>
            <TouchableOpacity onPress={()=>{handleDeleteTask(task.id)}}>
                <Text style={styles.itemDelete}>Delete</Text>
            </TouchableOpacity>
        </View>
    )

};
const styles = StyleSheet.create({
    itemContainer: {
        backgroundColor: '#333333',
        padding: 20,
        marginVertical: 8,
        borderRadius: 5,
        flexDirection: 'row',
        justifyContent: 'space-between',
        alignItems: 'center',
    },
    itemTitle: {
        color: "#ffffff"

    },
    itemDelete: {
        color: "#E4EDB9",
        backgroundColor:'#0D4665',
        borderRadius: 2,
        padding: 7,

    }
});

export default TaskItem;