document.addEventListener("DOMContentLoaded", () => {
    const form = document.getElementById("issuesForm");
    const inputs = document.querySelectorAll("#issuesForm input, #issuesForm select, #issuesForm textarea");
    const progressBar = document.getElementById("progressBar");

    function updateProgressBar() {
        let filled = 0;
        inputs.forEach(input => {
            if (input.type === "file") {
                if (input.files.length > 0) filled++;
            } else if (input.value.trim() !== "") {
                filled++;
            }
        });

        const percent = Math.round((filled / inputs.length) * 100);
        progressBar.style.width = percent + "%";
        progressBar.innerText = percent + "%";
        progressBar.setAttribute("aria-valuenow", percent);
    }

    inputs.forEach(input => {
        input.addEventListener("input", updateProgressBar);
        if (input.type === "file") {
            input.addEventListener("change", updateProgressBar);
        }
    });
});
