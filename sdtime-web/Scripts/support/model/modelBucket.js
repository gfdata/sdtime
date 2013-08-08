var Bucket = function (name, status, statusId, tickets) {
    this.name = name;
    this.status = status;
    this.statusId = statusId;
    this.latestTicket = ko.computed({
        read: function () {
            return 1;
        },
        write: function (value) {
            this.tickets.push(value);
        },
        owner: this
    });
    this.tickets = ko.observableArray();
    if (tickets) {
        for (var i = 0; i < tickets.length; i++) {
            this.tickets.push(new Ticket(tickets[i].name, tickets[i].number, tickets[i].assigned, tickets[i].client, tickets[i].description, tickets[i].budget, tickets[i].actual, tickets[i].ticketnotes, this));
        }
    };
    this.receive = function (ticket, index) {
        ticket.bucket(this);
        //this.tickets.splice(index, 0, ticket);
    }
    this.relinquish = function (ticket) {
        this.tickets.remove(ticket);
    }

}

var Board = function (name, id) {
    this.name = name;
    this.id = id;
};
 