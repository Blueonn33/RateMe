const apiBaseUrl = 'https://localhost:7170'
export const endpoints = {
    createPicture: () => `${apiBaseUrl}/api/create/picture`,
    loadPictures: () => `${apiBaseUrl}/api/pictures`,
}