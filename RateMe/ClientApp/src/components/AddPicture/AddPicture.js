import React, { Component } from 'react';
import { endpoints } from '../../endpoints';

export class AddPicture extends Component {
    static displayName = AddPicture.name;

    constructor(props) {
        super(props);
        this.state = {
            file: null
        };
    }

    handleFileChange = (event) => {
        this.setState({ file: event.target.files[0] });
    }

    createPicture = async (event) => {
        event.preventDefault();

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

    render() {
        return (
            <div>
                <form onSubmit={this.createPicture}>
                    <div>
                        <input type="file" onChange={this.handleFileChange} />
                    </div>
                    <button type="submit">Submit</button>
                </form>
            </div>
        );
    }
}
