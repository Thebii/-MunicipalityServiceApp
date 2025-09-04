function makeButtonNavigate(buttonId, url) {
        const btn = document.getElementById(buttonId);
        if (btn) {
            btn.addEventListener("click", function () {
                window.location.href = url;
            });
        } else {
            console.warn(`Button with ID "${buttonId}" not found.`);
        }
    }
    
makeButtonNavigate("btnReportIssues", "/ReportIssues/ReportIssues");
makeButtonNavigate("btnLocalEventsAndAnnouncements", "/LocalEventsAndAnnouncements/LocalEventsAndAnnouncements");
makeButtonNavigate("btnServiceRequestStatus", "/ServiceRequestStatus/ServiceRequestStatus");
