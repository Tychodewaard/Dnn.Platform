!function(t,n){"object"==typeof exports&&"object"==typeof module?module.exports=n(require("react"),require("react-collapse"),require("react-dom")):"function"==typeof define&&define.amd?define(["react","react-collapse","react-dom"],n):"object"==typeof exports?exports.Collapsible=n(require("react"),require("react-collapse"),require("react-dom")):t.Collapsible=n(t.react,t["react-collapse"],t["react-dom"])}(this,function(t,n,e){return function(t){function n(o){if(e[o])return e[o].exports;var i=e[o]={exports:{},id:o,loaded:!1};return t[o].call(i.exports,i,i.exports,n),i.loaded=!0,i.exports}var e={};return n.m=t,n.c=e,n.p="",n(0)}([function(t,n,e){"use strict";function o(t){return t&&t.__esModule?t:{"default":t}}function i(t,n){if(!(t instanceof n))throw new TypeError("Cannot call a class as a function")}function r(t,n){if(!t)throw new ReferenceError("this hasn't been initialised - super() hasn't been called");return!n||"object"!=typeof n&&"function"!=typeof n?t:n}function u(t,n){if("function"!=typeof n&&null!==n)throw new TypeError("Super expression must either be null or a function, not "+typeof n);t.prototype=Object.create(n&&n.prototype,{constructor:{value:t,enumerable:!1,writable:!0,configurable:!0}}),n&&(Object.setPrototypeOf?Object.setPrototypeOf(t,n):t.__proto__=n)}Object.defineProperty(n,"__esModule",{value:!0});var c=function(){function t(t,n){for(var e=0;e<n.length;e++){var o=n[e];o.enumerable=o.enumerable||!1,o.configurable=!0,"value"in o&&(o.writable=!0),Object.defineProperty(t,o.key,o)}}return function(n,e,o){return e&&t(n.prototype,e),o&&t(n,o),n}}(),a=e(4),s=o(a),l=e(5),p=o(l),f=e(6),d=e(3),m=o(d),h=300,w=/Firefox/.test(navigator.userAgent)?document.documentElement:document.body,b=function(t){function n(){return i(this,n),r(this,(n.__proto__||Object.getPrototypeOf(n)).apply(this,arguments))}return u(n,t),c(n,[{key:"componentWillUnmount",value:function(){this.scrollTimeout&&(clearTimeout(this.scrollTimeout),this.scrollTimeout=null)}},{key:"scroll",value:function(t){var n=this,e=this.props.scrollDelay,o=e||0===e?e:h;this.props.isOpened&&this.props.autoScroll&&(this.scrollTimeout=setTimeout(function(){var e=(0,f.findDOMNode)(n.refs.collapsible),o=e.getBoundingClientRect().top,i=n.props.fixedHeight||t,r=document.body.getBoundingClientRect().top,u=o-r+i+40;u>window.innerHeight&&(u-=window.innerHeight,u>window.scrollY&&m["default"].top(w,u))},o),"function"==typeof this.props.onHeightReady&&this.props.onHeightReady(t))}},{key:"render",value:function(){var t=this.props,n=t.isOpened,e=t.style,o=t.fixedHeight,i=this.props.className||"";return s["default"].createElement(p["default"],{isOpened:n,style:e,ref:"collapsible",keepCollapsedContent:!0,className:i,onHeightReady:this.scroll.bind(this),fixedHeight:o},this.props.children)}}]),n}(a.Component);n["default"]=b,b.propTypes={isOpened:a.PropTypes.bool,style:a.PropTypes.object,fixedHeight:a.PropTypes.number,autoScroll:a.PropTypes.bool,scrollDelay:a.PropTypes.number,onHeightReady:a.PropTypes.func,children:a.PropTypes.node,className:a.PropTypes.string}},function(t,n){n.linear=function(t){return t},n.inQuad=function(t){return t*t},n.outQuad=function(t){return t*(2-t)},n.inOutQuad=function(t){return t*=2,t<1?.5*t*t:-.5*(--t*(t-2)-1)},n.inCube=function(t){return t*t*t},n.outCube=function(t){return--t*t*t+1},n.inOutCube=function(t){return t*=2,t<1?.5*t*t*t:.5*((t-=2)*t*t+2)},n.inQuart=function(t){return t*t*t*t},n.outQuart=function(t){return 1- --t*t*t*t},n.inOutQuart=function(t){return t*=2,t<1?.5*t*t*t*t:-.5*((t-=2)*t*t*t-2)},n.inQuint=function(t){return t*t*t*t*t},n.outQuint=function(t){return--t*t*t*t*t+1},n.inOutQuint=function(t){return t*=2,t<1?.5*t*t*t*t*t:.5*((t-=2)*t*t*t*t+2)},n.inSine=function(t){return 1-Math.cos(t*Math.PI/2)},n.outSine=function(t){return Math.sin(t*Math.PI/2)},n.inOutSine=function(t){return.5*(1-Math.cos(Math.PI*t))},n.inExpo=function(t){return 0==t?0:Math.pow(1024,t-1)},n.outExpo=function(t){return 1==t?t:1-Math.pow(2,-10*t)},n.inOutExpo=function(t){return 0==t?0:1==t?1:(t*=2)<1?.5*Math.pow(1024,t-1):.5*(-Math.pow(2,-10*(t-1))+2)},n.inCirc=function(t){return 1-Math.sqrt(1-t*t)},n.outCirc=function(t){return Math.sqrt(1- --t*t)},n.inOutCirc=function(t){return t*=2,t<1?-.5*(Math.sqrt(1-t*t)-1):.5*(Math.sqrt(1-(t-=2)*t)+1)},n.inBack=function(t){var n=1.70158;return t*t*((n+1)*t-n)},n.outBack=function(t){var n=1.70158;return--t*t*((n+1)*t+n)+1},n.inOutBack=function(t){var n=2.5949095;return(t*=2)<1?.5*(t*t*((n+1)*t-n)):.5*((t-=2)*t*((n+1)*t+n)+2)},n.inBounce=function(t){return 1-n.outBounce(1-t)},n.outBounce=function(t){return t<1/2.75?7.5625*t*t:t<2/2.75?7.5625*(t-=1.5/2.75)*t+.75:t<2.5/2.75?7.5625*(t-=2.25/2.75)*t+.9375:7.5625*(t-=2.625/2.75)*t+.984375},n.inOutBounce=function(t){return t<.5?.5*n.inBounce(2*t):.5*n.outBounce(2*t-1)+.5},n["in-quad"]=n.inQuad,n["out-quad"]=n.outQuad,n["in-out-quad"]=n.inOutQuad,n["in-cube"]=n.inCube,n["out-cube"]=n.outCube,n["in-out-cube"]=n.inOutCube,n["in-quart"]=n.inQuart,n["out-quart"]=n.outQuart,n["in-out-quart"]=n.inOutQuart,n["in-quint"]=n.inQuint,n["out-quint"]=n.outQuint,n["in-out-quint"]=n.inOutQuint,n["in-sine"]=n.inSine,n["out-sine"]=n.outSine,n["in-out-sine"]=n.inOutSine,n["in-expo"]=n.inExpo,n["out-expo"]=n.outExpo,n["in-out-expo"]=n.inOutExpo,n["in-circ"]=n.inCirc,n["out-circ"]=n.outCirc,n["in-out-circ"]=n.inOutCirc,n["in-back"]=n.inBack,n["out-back"]=n.outBack,n["in-out-back"]=n.inOutBack,n["in-bounce"]=n.inBounce,n["out-bounce"]=n.outBounce,n["in-out-bounce"]=n.inOutBounce},function(t,n){function e(t){var n=(new Date).getTime(),e=Math.max(0,16-(n-o)),i=setTimeout(t,e);return o=n,i}n=t.exports=window.requestAnimationFrame||window.webkitRequestAnimationFrame||window.mozRequestAnimationFrame||window.oRequestAnimationFrame||window.msRequestAnimationFrame||e;var o=(new Date).getTime(),i=window.cancelAnimationFrame||window.webkitCancelAnimationFrame||window.mozCancelAnimationFrame||window.oCancelAnimationFrame||window.msCancelAnimationFrame||window.clearTimeout;n.cancel=function(t){i.call(window,t)}},function(t,n,e){function o(t,n,e,o,u){function c(){p=!0}function a(o){if(p)return u(new Error("Scroll cancelled"),n[t]);var r=+new Date,c=Math.min(1,(r-s)/d),f=m(c);n[t]=f*(e-l)+l,c<1?i(a):u(null,n[t])}var s=+new Date,l=n[t],p=!1,f="inOutSine",d=350;"function"==typeof o?u=o:(o=o||{},f=o.ease||f,d=o.duration||d,u=u||function(){});var m=r[f];return l===e?u(new Error("Element already at target scroll position"),n[t]):(i(a),c)}var i=e(2),r=e(1);t.exports={top:function(t,n,e,i){return o("scrollTop",t,n,e,i)},left:function(t,n,e,i){return o("scrollLeft",t,n,e,i)}}},function(n,e){n.exports=t},function(t,e){t.exports=n},function(t,n){t.exports=e}])});