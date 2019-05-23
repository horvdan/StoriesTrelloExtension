import { Storyboard } from "./model";

const get = async (url) => {
    return fetch(url, {
        method: 'GET',
        mode: 'cors',
        headers: {
            'Content-Type': 'application/json',
        }
    })
    .then(response => response.json());
};

export const getStoryboard = (): Promise<Storyboard> => {
    return get('https://localhost:5001/api/storyboard');
};
