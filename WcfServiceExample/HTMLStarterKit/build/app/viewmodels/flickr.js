define(["plugins/http","durandal/app","knockout"],function(t,e,a){return{displayName:"Flickr",images:a.observableArray([]),activate:function(){if(!(this.images().length>0)){var e=this;return t.jsonp("http://api.flickr.com/services/feeds/photos_public.gne",{tags:"mount ranier",tagmode:"any",format:"json"},"jsoncallback").then(function(t){e.images(t.items)})}},select:function(t){t.viewUrl="views/detail",e.showDialog(t)},canDeactivate:function(){return e.showMessage("Are you sure you want to leave this page?","Navigate",["Yes","No"])}}});