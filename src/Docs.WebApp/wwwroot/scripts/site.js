
var renderEvents = [];

function onRendered(event) {
    renderEvents.push(event);
}

window.rendered = (firstTime) => {
    for (var i in renderEvents)
        renderEvents[i](firstTime);
};


window.fixCodePadding = id => {
    setTimeout(() => {
        var e = document.getElementById(id);
        if (!e) return;
        e.innerHTML = e.innerHTML.replace(/^\s+|\s+$/g, '');

    }, 200);
}

function startup() {
    setTimeout(() => {
        hljs.highlightAll();
        hljs.addPlugin(new CopyButtonPlugin());
    }, 200);
}

window.startup = startup;