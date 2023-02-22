import API from "../Utils/axios.config";
export default function getRandomChuck(){
    return API.get('/jokes/random',{
        validateStatus : (status) => status < 500
    }
    )
}