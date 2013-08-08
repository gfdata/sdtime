// This is a simple *viewmodel* - JavaScript that defines the data and behavior of your UI
function SupportViewModel() {
    //var parsed = JSON.parse('[{"name":"New","status":"New","tickets":[{"name":"Fix the thing","client":"Refinery","budget":10,"ticketnotes":[{"note":"Not sure about issue"},{"note":"Read this"}]},{"name":"Change other thing","client":"Dwell","budget":5,"ticketnotes":[{"note":"found the cause"}]}]},{"name":"In Progress","status":"In Progress","tickets":[{"name":"Fix the other thing","client":"Nike","budget":4,"ticketnotes":[{"note":"Found it"}]}]}]');
    //var parsed = JSON.parse('[{ "name": "Assigned", "status": "Assigned", "tickets": [{ "name": "Tracking numbers are not working on shipping confirmation emails", "client": "DwellStudio", "number": 29589, "assigned": "Ryan Gellis", "description": "", "budget": 0}] }, { "name": "In Progress", "status": "In Progress", "tickets": [{ "name": "RE: Feed testing for BARNA rules", "client": "Skadden, Arps, Slate, Flom LLP", "number": 31183, "assigned": "Dmitriy Osyannikov", "description": "", "budget": 0 }, { "name": "Forms needed", "client": "City Parks Foundation", "number": 31301, "assigned": "Guojing Yuan", "description": "", "budget": 16 }, { "name": "Add onclick GA tracking to AJAX-controlled content areas", "client": "Skadden, Arps, Slate, Flom LLP", "number": 31616, "assigned": "Dmitriy Osyannikov", "description": "", "budget": 0}] }, { "name": "Internal QA", "status": "Internal QA", "tickets": [{ "name": "Product Reviews produces an error", "client": "DwellStudio", "number": 30929, "assigned": "Guojing Yuan", "description": "", "budget": 3 }, { "name": "Clean up logs", "client": "DwellStudio", "number": 31000, "assigned": "Guojing Yuan", "description": "", "budget": 2 }, { "name": "Alumni: optimize CSV import", "client": "Skadden, Arps, Slate, Flom LLP", "number": 31441, "assigned": "Dmitriy Osyannikov", "description": "", "budget": 0}] }, { "name": "New", "status": "New", "tickets": [{ "name": "Create and organize SD design folder", "client": "Something Digital", "number": 31650, "assigned": "Mickey Winter", "description": "", "budget": 0}] }, { "name": "Pending Production Deployment", "status": "Pending Production Deployment", "tickets": [{ "name": "Performance Optimizations", "client": "DwellStudio", "number": 25928, "assigned": "Ryan Gellis", "description": "", "budget": 0}] }, { "name": "Ready for Development", "status": "Ready for Development", "tickets": [{ "name": "Drupal CMS: Add Save, Preview, and Delete buttons/links at the top of edit screens", "client": "Skadden, Arps, Slate, Flom LLP", "number": 29198, "assigned": "Dmitriy Osyannikov", "description": "", "budget": 6}]}]');
    //var parsed = JSON.parse('[{"name":"Assigned","status":"Assigned","tickets":[{"name":"Patch the USPS Rate Change","client":"Ariela-Alpha International","number":29529,"assigned":"Ryan Gellis","description":"","budget":12},{"name":"Tracking numbers are not working on shipping confirmation emails","client":"DwellStudio","number":29589,"assigned":"Ryan Gellis","description":"","budget":0},{"name":"Send shipping confirmation emails for dropshipped products","client":"DwellStudio","number":30532,"assigned":"Ryan Gellis","description":"","budget":6},{"name":"Practices: complete migration of 4 externally-hosted practices to skadden.com","client":"Skadden, Arps, Slate, Meagher  Flom LLP","number":30726,"assigned":"Anna Phillips","description":"","budget":0},{"name":"Add &quot;Cancel&quot; Button to step 1 of customizer","client":"Papyrus","number":30970,"assigned":"Pream Totaram","description":"","budget":2}]}]');
    // var parsed = JSON.parse('[{"name":"Assigned","status":"Assigned","tickets":[{"name":"Patch\\" the USPS Rate Change","client":"Ariela-Alpha International","number":29529,"assigned":"Ryan Gellis","description":"","budget":12},{"name":"Tracking numbers are not working on shipping confirmation emails","client":"DwellStudio","number":29589,"assigned":"Ryan Gellis","description":"","budget":0},{"name":"Send shipping confirmation emails for dropshipped products","client":"DwellStudio","number":30532,"assigned":"Ryan Gellis","description":"","budget":6},{"name":"Practices: complete migration of 4 externally-hosted practices to skadden.com","client":"Skadden, Arps, Slate, Meagher & Flom LLP","number":30726,"assigned":"Anna Phillips","description":"","budget":0},{"name":"Add Cancel Button to step 1 of customizer","client":"Papyrus","number":30970,"assigned":"Pream Totaram","description":"","budget":2},{"name":"Setup New Papyrus Staging instance with Aheadsworks Mobile (papyrusmobile.somethingdigital.com)","client":"Papyrus","number":31189,"assigned":"Ryan Gellis","description":"","budget":5},{"name":"Implement different capture workflow for vouchers vs. products","client":"Refinery29, Inc.","number":31218,"assigned":"Ryan Gellis","description":"","budget":40},{"name":"Set up Healthcheck for Product / Category Index","client":"DwellStudio","number":31282,"assigned":"Phillip Jackson","description":"","budget":0},{"name":"Purchase tickets button for Grand Gourmet","client":"Grand Central Partnership","number":31553,"assigned":"Jesse Smith","description":"","budget":0},{"name":"Add publications section to professional profile / bio pages","client":"Clayman & Rosenberg LLP","number":31560,"assigned":"Jesse Smith","description":"","budget":0}]},{"name":"Discovery","status":"Discovery","tickets":[{"name":"Gift Cards and Gift Certificates","client":"DwellStudio","number":29429,"assigned":"Jonathan Tudhope","description":"","budget":0}]},{"name":"In Progress","status":"In Progress","tickets":[{"name":"Change Out of Stock Behavior","client":"Gretchen Scott LLC","number":29634,"assigned":"Ryan Gellis","description":"","budget":30},{"name":"Map Manufacturer attribute for FG product uploads","client":"Papyrus","number":30106,"assigned":"Pream Totaram","description":"","budget":8},{"name":"T&C - Cart Abandonment emails","client":"Full Picture","number":30626,"assigned":"Guojing Yuan","description":"","budget":2},{"name":"T&C - Cart Abandonment emails","client":"Full Picture","number":30626,"assigned":"Guojing Yuan","description":"","budget":2},{"name":"MRU registration form","client":"Medicare Rights Center","number":30802,"assigned":"Pream Totaram","description":"","budget":30},{"name":"Retail customers periodically see wholesale pricing","client":"Gretchen Scott LLC","number":30848,"assigned":"Guojing Yuan","description":"","budget":8},{"name":"Reindexing issue is dropping products off the site","client":"DwellStudio","number":30954,"assigned":"Phillip Jackson","description":"","budget":0},{"name":"RE: Feed testing for BARNA rules","client":"Skadden, Arps, Slate, Meagher & Flom LLP","number":31183,"assigned":"Dmitriy Osyannikov","description":"","budget":0},{"name":"Upgrade Exactor extension","client":"Papyrus","number":31213,"assigned":"Pream Totaram","description":"","budget":2},{"name":"Forms needed","client":"City Parks Foundation","number":31301,"assigned":"Guojing Yuan","description":"","budget":16},{"name":"Review and categorize failed Saks orders","client":"Hearst Communications, Inc","number":31550,"assigned":"Pream Totaram","description":"","budget":30},{"name":"Daily health checks -- March 2013","client":"Skadden, Arps, Slate, Meagher & Flom LLP","number":31558,"assigned":"Dmitriy Osyannikov","description":"","budget":0},{"name":"Provider locator data updates - March 2013","client":"US Family Health Plan","number":31577,"assigned":"Pream Totaram","description":"","budget":1},{"name":"Add onclick GA tracking to AJAX-controlled content areas","client":"Skadden, Arps, Slate, Meagher & Flom LLP","number":31616,"assigned":"Dmitriy Osyannikov","description":"","budget":0}]},{"name":"Internal QA","status":"Internal QA","tickets":[{"name":"QA and Deploy GoMage Advanced Navigation","client":"Soludos LLC","number":30464,"assigned":"Ryan Gellis","description":"","budget":9},{"name":"Fix incorrect time zone on Report \u003e Sales \u003e Orders","client":"DwellStudio","number":30691,"assigned":"Guojing Yuan","description":"","budget":2},{"name":"Product Reviews produces an error","client":"DwellStudio","number":30929,"assigned":"Guojing Yuan","description":"","budget":3},{"name":"Clean up logs","client":"DwellStudio","number":31000,"assigned":"Guojing Yuan","description":"","budget":2},{"name":"Sprint 1.1","client":"Papyrus","number":31344,"assigned":"Pream Totaram","description":"","budget":7},{"name":"Alumni: optimize CSV import","client":"Skadden, Arps, Slate, Meagher & Flom LLP","number":31441,"assigned":"Dmitriy Osyannikov","description":"","budget":0},{"name":"Adjust search result links to external practice sites","client":"Skadden, Arps, Slate, Meagher & Flom LLP","number":31523,"assigned":"Dmitriy Osyannikov","description":"","budget":0},{"name":"Modelinia Pinterest verification","client":"Full Picture","number":31530,"assigned":"Guojing Yuan","description":"","budget":1},{"name":"Sprint 1.1","client":"DwellStudio","number":31556,"assigned":"Guojing Yuan","description":"","budget":1}]},{"name":"New","status":"New","tickets":[{"name":"Create and organize SD design folder","client":"Something Digital","number":31650,"assigned":"Mickey Winter","description":"","budget":0}]},{"name":"On-Hold","status":"On-Hold","tickets":[{"name":"Updated Rackspace Ticket #121116-04792: Notice of Critical PHP Injection Vulnerability","client":"Full Picture","number":29449,"assigned":"David Borishansky","description":"","budget":0.5}]},{"name":"Pending Production Deployment","status":"Pending Production Deployment","tickets":[{"name":"Performance Optimizations","client":"DwellStudio","number":25928,"assigned":"Ryan Gellis","description":"","budget":0},{"name":"Provide way to control canonical URLs in Magento","client":"DwellStudio","number":29952,"assigned":"Guojing Yuan","description":"","budget":1.97},{"name":"Add to cart message displays incorrectly on sheet sets","client":"DwellStudio","number":30068,"assigned":"Guojing Yuan","description":"","budget":0},{"name":"Reports \u003e Sales \u003e Orders does not work in IE9","client":"DwellStudio","number":30540,"assigned":"Guojing Yuan","description":"","budget":1.25},{"name":"Sales report changes","client":"DwellStudio","number":30741,"assigned":"Guojing Yuan","description":"","budget":3},{"name":"Update email signup image","client":"DwellStudio","number":30927,"assigned":"Guojing Yuan","description":"","budget":1}]},{"name":"Pending Time (Otherwise Complete)","status":"Pending Time (Otherwise Complete)","tickets":[{"name":"Dropship Vendor attribute defaults to Bazaar","client":"Hearst Communications, Inc","number":30745,"assigned":"Phillip Jackson","description":"","budget":0},{"name":"Sync live Nextopia files to staging","client":"DwellStudio","number":31358,"assigned":"Guojing Yuan","description":"","budget":1},{"name":"Inventory Update Issue","client":"Papyrus","number":31552,"assigned":"Pream Totaram","description":"","budget":8}]},{"name":"Ready for Development","status":"Ready for Development","tickets":[{"name":"Drupal CMS: Add Save, Preview, and Delete buttons/links at the top of edit screens","client":"Skadden, Arps, Slate, Meagher & Flom LLP","number":29198,"assigned":"Dmitriy Osyannikov","description":"","budget":6}]}]');


    buckets = ko.observableArray();
    members = ko.observableArray();
    selectedMembers = ko.observableArray();
    selectedMember = ko.observable('');

    clients = ko.observableArray();
    selectedClients= ko.observableArray();
    selectedClient = ko.observable('');

    boards = ko.observableArray();
    selectedBoard = ko.observable('');

    showOnlyThisWeek = ko.observable(true);

    loadData = function () {
               
                
        buckets.removeAll();
        membersParameter = "";
        clientsParameter = "";
        for (var i = 0; i < selectedMembers().length; i++) {
            membersParameter += "members=" + selectedMembers()[i].memberId + "&";
        }
        for (var i = 0; i < selectedClients().length; i++) {
            clientsParameter += "clients=" + selectedClients()[i].clientId + "&";
        }
        
        //alert(showOnlyThisWeek());

        //console.log("/SupportServices/ServiceBoard?" + membersParameter + clientsParameter);
        $.getJSON("/SupportServices/ServiceBoard?" + membersParameter + clientsParameter + "board=" + selectedBoard().id + "&weekView=" + showOnlyThisWeek(), function (data) {
            data.buckets.sort(function (left, right) {
                return left.sortOrder == right.sortOrder ? 0 : (left.sortOrder < right.sortOrder ? -1 : 1)
            });
            for (var i = 0; i < data.buckets.length; i++) {
                buckets.push(new Bucket(data.buckets[i].name, data.buckets[i].status, data.buckets[i].statusId, data.buckets[i].tickets));
                
            }
            if (members().length == 0) {
                members.push(new Member(-1, "All Staff"));
                for (var i = 0; i < data.members.length; i++) {
                    members.push(new Member(data.members[i].memberId, data.members[i].fullName));
                }
            }
            if (clients().length == 0) {
                clients.push(new Client(-1, "All Clients"));
                for (var i = 0; i < data.clients.length; i++) {
                    clients.push(new Client(data.clients[i].clientId, data.clients[i].clientName));
                }
            }
			
			// Set container width based on number of items
			var bucketWidth = 200,
			bucketMargin = 7;
			$("#container").width((data.buckets.length * (bucketWidth + bucketMargin)) + bucketMargin);
        });

    }
	
	function showFilterBar() {
		$(".filter-bar").show();
		// Adjust container padding for filter bar
		$("#container").css("padding-top", $("header").outerHeight());
		
	}
	
	function hideFilterBar() {
		// If the last item has just been removed from the filter bar
		if(!$(".filter-bar").children().length) {
			$(".filter-bar").hide();
			// Clear inline styles
			$("#container").css("padding-top", "");
		}
	}

	toggleDateFilter = function () {
	    members.removeAll();
	    clients.removeAll();
	    loadData();
	    return true;
	}

	changeServiceBoard = function () {
	    members.removeAll();
	    clients.removeAll();
	    loadData();
	}

    addSelectedEmployee = function () {
        if (selectedMember() && selectedMember().fullName != "All Staff") {
            selectedMembers.push(selectedMember());
            loadData();
			showFilterBar();
        }
    }

    removeSelectedEmployee = function (data) {
        selectedMembers.remove(data);
        loadData();
		hideFilterBar();
    }

    addSelectedClient = function () {
        if (selectedClient() && selectedClient().clientName != "All Clients") {
            selectedClients.push(selectedClient());
            loadData();
			showFilterBar();
        }
    }

    removeSelectedClient = function (data) {
        selectedClients.remove(data);
        loadData();
		hideFilterBar();
    }

    boards.removeAll();
    boards.push(new Board("Interactive Service", 11));
    boards.push(new Board("Software Service", 12));
    boards.push(new Board("Interactive Project", 14));
    boards.push(new Board("Software Project", 15));



    loadData();

    
	
}

// Activates knockout.js
ko.applyBindings(new SupportViewModel());