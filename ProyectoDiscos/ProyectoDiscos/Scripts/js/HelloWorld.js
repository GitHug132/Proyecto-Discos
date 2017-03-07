var HelloWorld = React.createClass({
    render: function(){
        return (
            <div>Hello World </div>
            );
}
});
 
React.render( 
    <HelloWorld name="World" />, 
    document.getElementById('container')
);