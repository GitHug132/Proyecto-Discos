var HelloWorld = React.createClass({

getInitialState: function() {
    var request = $.ajax({
        url: "/api/Discos",
        type: "GET",
        contentType: 'application/json',
        dataType: "json",
        success: function (list) {
            this.setState({list:list})

        }.bind(this),
        error: function (e) {
            console.log(e.responseText)
        }.bind(this)
    });
    return { list:[]};
  },
componentDidMount: function() {
    

  },
    render : function(){
        const ListaMostrar = this.state.list
        const arr = [];
        $.each(ListaMostrar, function () { arr.push(this); });

        {ListaMostrar.map(item =>
            <p>{item.idDisco}<p>
            )}
        const listItems;
        listItems = arr.map((item) =>
            <li>{item.idDisco}</li>
        );

        console.log(ListaMostrar);
        return (
          <div>
          <h3>Lista Discos</h3>
               <ul>{listItems}</ul>
          </div>
        );
        
});




React.render(
  <HelloWorld />,
  document.getElementById('lista')
);