import { Button } from '@mui/material';
import React, { useEffect, useState } from 'react';
import getRandomChuck from '../Service/axiosService';

const ChuckJokes = () => {
    const [joke, setJoke] = useState({});
    const [likes, setLikes] = useState(0);
    const [unlikes, setUnlikes] = useState(0);
    useEffect(() => {
        
        return () => {
            updateJoke();
        };
    }, []);
    const updateJoke=()=>{
        getRandomChuck()
        .then((res) => {
            if (res.status === 200)
                setJoke(res.data);
        })
        .catch()
    }
    const likeButton = ()=>{
        setLikes(likes + 1)
    }
    const unlikeButton = ()=>{
        setUnlikes(unlikes + 1)
    }
    return (
        <div>
            <h2> Chuck Jokes</h2>
            <img alt='Chuck' src='src\img\chuckNorris_logo.png' />
            <h3>Chuck Say´s:</h3>
            <p>{joke.value}</p>
            <button onClick={updateJoke}>Get another Joke!</button>
            <p>If you like any, you can vote  on liked or unliked, ever you vote add a point on each category.</p>
            <Button variant="contained" onClick={likeButton}>Like</Button>
            <p>Likes : {likes}</p>
            <Button variant="outlined" onClick={unlikeButton}>Unlike</Button>
            <p>Unlikes : {unlikes}</p>


        </div>
    );
}

export default ChuckJokes;
