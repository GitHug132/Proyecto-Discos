<<<<<<< HEAD
﻿var HelloWorld = React.createClass({
    render: function() {
        return <div>Hello world!</div>;
    }
});

React.render(
  <HelloWorld />,
  document.getElementById('content')
=======
﻿
var HelloWorld = React.createClass({
    render: function(){
        return (
            <div>Hello {this.props.name}</div>
            );
}
});

React.render(
    <HelloWorld name="World" />,
    document.getElementById('container')
>>>>>>> 0d777877a45e9ae238c512e82138b78e220f8481
);