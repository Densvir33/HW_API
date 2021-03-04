    fetch("https://localhost:44333/api/Animal", {
                method: "GET"
            })
                .then(response => response.json())
                .then(json => {
                    for (var i = 0; i < json.length; i++) {
                        document.getElementById("animals").innerHTML += `
                        <button class="btn">
                            <div class="btn-div">
                                <div>
                                    <p>Name: ${json[i].name}</p>
                                    <p>Type: ${json[i].type}</p>
                                    <p>Age: ${json[i].age}</p>
                                </div>
                                <div class="btn-div">
                                    <button class="btn-crud" onclick="Edit()">Edit</button>
                                    <button class="btn-crud" onclick="Delete()">Delete</button>
                                </div>
                            </div>
                        </button>
                        `
                    }
                })
                .catch(err => console.log(err))

                function submitForm()
                {
                    var data =
                    {
                        id:5,
                        name: document.getElementById("name").value,
                        age: parseInt(document)
                    }
                }