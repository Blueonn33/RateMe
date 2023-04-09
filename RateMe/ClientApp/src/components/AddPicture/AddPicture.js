import React, { Component } from 'react';
import { endpoints } from '../../endpoints';
import PicturesContainer from '../PicturesContainer/PicturesContainer';

export class AddPicture extends Component {
    static displayName = AddPicture.name;

    constructor(props) {
        super(props);
        this.state = {
            file: null,
            imageData: null,
            pictures: [],
        };
        this.loadPictures = this.loadPictures.bind(this);
    }

    async componentDidMount() {
        this.loadPictures();
    }

    //handleFileChange = (event) => {
    //    this.setState({ file: event.target.files[0] });
    //}

    //handleFileChange = (event) => {
    //    const file = event.target.files[0];
    //    const reader = new FileReader();
    //    reader.onloadend = () => {
    //        this.setState({
    //            imageData: reader.result,
    //        });
    //    };
    //    reader.readAsDataURL(file);
    //};

    handleFileChange = (event) => {
        this.setState({ file: event.target.files[0] });
        const file = event.target.files[0];
        const reader = new FileReader();
        reader.onloadend = () => {
            this.setState({
                imageData: reader.result,
            });
        };
        reader.readAsDataURL(file);
    };

    createPicture = async () => {
        //event.preventDefault();

        const formData = new FormData();
        formData.append('file', this.state.file);

        const response = await fetch(endpoints.createPicture(), {
            method: 'POST',
            body: formData
        });

        if (response.ok) {
            const picture = await response.json();
            console.log(picture);
        } else {
            console.error(response.statusText);
        }
        //const formData = new FormData();
        //formData.append('name', this.state.file.name);
        //formData.append('data', this.state.file);

        //fetch(endpoints.createPicture(), {
        //    method: 'POST',
        //    body: formData
        //})
        //    .then(response => {
        //        if (response.ok) {
        //            console.log('Picture added successfully');
        //        }
        //        else {
        //            console.error('Failed to add picture');
        //        }
        //    });
    }

    async loadPictures() {
        await fetch(endpoints.loadPictures())
            .then((res) => res.json())
            .then((res) => this.setState({ pictures: res }))
            .catch(error => console.error(error));
    }

    render() {
        const { imageData } = this.state;
        return (
            <div>
                <div>
                    <form onSubmit={this.createPicture}>
                        <div>
                            {/*<input type="file" onChange={this.handleFileChange} />*/}
                            <input type="file" onChange={this.handleFileChange} />
                            {imageData && <img src={imageData} alt="Preview" width='500' height='400' />}
                        </div>
                        <button type="submit">Submit</button>
                    </form>
                </div>
                <div className='picturesContainers'>
                    {this.state.pictures.map((picture) => {
                        return (
                            <PicturesContainer pictureData={picture} key={picture.id} />
                        )
                    })}
                </div>
                {/*<div>*/}
                {/*    {this.state.pictures.map(url => (*/}
                {/*        <img key={url} src={this.state.imageData} alt="Image"  width='500' height='400'/>*/}
                {/*    ))}*/}
                {/*</div>*/}
            </div>
        );
    }
}
