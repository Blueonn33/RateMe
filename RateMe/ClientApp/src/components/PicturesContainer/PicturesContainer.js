import React, { Component } from 'react';

export default class PicturesContainer extends Component {

    handleFileChange = (image) => {
        const file = image;
        const reader = new FileReader();
        reader.readAsDataURL(file);
    };

    render() {
        
        return (
            <div className='picturesContainer d-flex' key={this.props.pictureData.id}>
                <div className='pictureNameWrapper'>
                    <span className='pictureName pageText'> {this.props.pictureData.name} </span>
                </div>
                <div>
                    {/*<img src={this.handleFileChange(this.props.pictureData.data)} />*/}
                    <img src={this.props.pictureData.data} width='200' height='200' />
                </div>
                <div className='usePictureButtonWrapper ml-auto'>
                    <button className='useButton'>
                        <a href={`ToDo`} className='useButtonText'>Използвай</a>
                    </button>
                </div>
            </div>
        )
    }
}
