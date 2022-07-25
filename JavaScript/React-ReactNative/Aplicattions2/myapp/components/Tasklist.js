import React, { useState, useEffect } from "react";
import { View, Text, FlatList } from 'react-native';
import TaskItem from "./Taskitem";
import { getTasks, deleteTask } from "../api";
import { RefreshControl } from "react-native-web";
import { useIsFocused } from "@react-navigation/native";

const TaskLists = () => {

    const [tasks, setTasks] = useState([]);
    const [refreshing, setRefreshing] = useState(false);

    const focused = useIsFocused();

    const loadTasks = async () => {
        const data = await getTasks();

        setTasks(data);

    };

    useEffect(() => {
        loadTasks();
    }, [focused]);

    const handleDeleteTask = async (id) => {
        await deleteTask(id);
        await loadTasks();
    }

    const renderItem = ({ item }) => {

        return <TaskItem task={item} handleDeleteTask={handleDeleteTask} />
    }

    const onRefresh = React.useCallback(async () => {
        setRefreshing(true);
        await loadTasks();
        setRefreshing(false);
    })

    return (
        <FlatList
            style={{ width: '100%' }}
            data={tasks}
            keyExtractor={(item) => { item.id + '' }}
            renderItem={renderItem}
            refreshControl={
                <RefreshControl
                    refreshing={refreshing}
                    colors={['#78e08f']}
                    onRefresh={onRefresh}
                    progressBackgroundColor="#0a3d62"
                />}
        />
    )
}
export default TaskLists;