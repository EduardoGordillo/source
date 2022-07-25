import React from 'react';
import { Text, TouchableOpacity, Button } from "react-native-web";
import { NavigationContainer } from '@react-navigation/native';
import { createNativeStackNavigator } from '@react-navigation/native-stack';

import Homescreen from './screens/Homescreen';
import TaskFormScreen from './screens/TaskFormscreen';


const Stack = createNativeStackNavigator();

const App = () => {
  return (
    <NavigationContainer>
      <Stack.Navigator>
        <Stack.Screen name='Homescreen' component={Homescreen}
          
          options={({navigation})=> ({
            title: 'Task App',
            headerStyle: { backgroundColor: '#222f3e' },
            headerTitleStyle: { color: '#ffffff', marginLeft: '25px' },
            headerRight:()=>(
            <TouchableOpacity onPress={()=> navigation.navigate('TaskFormScreen')}>
              <Text style={{color: '#E4EDB9', marginRight: 35, fontSize:  18}}>New</Text>
            </TouchableOpacity>

          ),
          })} />
        <Stack.Screen name='TaskFormScreen' component={TaskFormScreen} 
        options={{
          title: 'Create Task',
          headerStyle:{backgroundColor: '#222f3e'},
          headerTitleStyle:{color: '#ffffff'},
          headerTintColor: '#ffffff',


        }}
        />
        
      </Stack.Navigator>

    </NavigationContainer>
  )
}

export default App