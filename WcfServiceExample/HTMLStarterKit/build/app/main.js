requirejs.config({paths:{text:"../lib/require/text",durandal:"../lib/durandal/js",plugins:"../lib/durandal/js/plugins",transitions:"../lib/durandal/js/transitions",knockout:"../lib/knockout/knockout-2.3.0",bootstrap:"../lib/bootstrap/js/bootstrap",jquery:"../lib/jquery/jquery-1.9.1"},shim:{bootstrap:{deps:["jquery"],exports:"jQuery"}}}),define(["durandal/system","durandal/app","durandal/viewLocator"],function(t,e,r){t.debug(!0),e.title="Durandal Starter Kit",e.configurePlugins({router:!0,dialog:!0,widget:!0}),e.start().then(function(){r.useConvention(),e.setRoot("viewmodels/shell","entrance")})});