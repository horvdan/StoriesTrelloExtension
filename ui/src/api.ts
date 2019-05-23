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

export const getStoryboard = async () => {
    return await get('https://localhost:5001/api/storyboard');
};
