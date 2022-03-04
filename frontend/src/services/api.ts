import axios from "axios"
import {Article} from "@/types/types";

const client = axios.create({
    baseURL: "https://localhost:5001/api",
    withCredentials: false,
    headers: {
        Accept: "application/json",
        "Content-Type": "application/json",
        "Access-Control-Allow-Origin" : "*",
    },
})

client.interceptors.response.use(
    (response) => {
        console.log(response.data)
        return response.data
    },
    (error) => {
        console.log(error)

    }
)

export default{
    getAllArticles: async (): Promise<Article[]> => {
        return await  client.get("/Article")
    }
    ,
    getArticleById: async (id: number): Promise<Article[]> => {
        return await  client.get(`/Article/${id}`)
    },
    postArticle: async (): Promise<void> => {
        return await client.post("/Article")
    }

}

