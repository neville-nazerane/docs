
var renderEvents = [];

function onRendered(event) {
    renderEvents.push(event);
}

window.rendered = (firstTime) => {
    for (var i in renderEvents)
        renderEvents[i](firstTime);
};
