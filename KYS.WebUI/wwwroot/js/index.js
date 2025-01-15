document.addEventListener("DOMContentLoaded", function () {
    const themeToggle = document.getElementById('themeToggle');
    const themeIcon = document.getElementById('themeIcon');
    const body = document.body;

    const savedTheme = localStorage.getItem('theme') || 'light-theme';
    body.className = savedTheme;
    themeIcon.className = savedTheme === 'light-theme' ? 'bi bi-moon-stars' : 'bi bi-sun';

    themeToggle?.addEventListener('click', () => {
        if (body.classList.contains('light-theme')) {
            body.className = 'dark-theme';
            themeIcon.className = 'bi bi-sun';
            localStorage.setItem('theme', 'dark-theme');
        } else {
            body.className = 'light-theme';
            themeIcon.className = 'bi bi-moon-stars';
            localStorage.setItem('theme', 'light-theme');
        }
    });

    const sidebar = document.getElementById('sidebar');
    const sidebarCollapse = document.getElementById('sidebarCollapse');

    sidebarCollapse?.addEventListener('click', () => {
        sidebar.classList.toggle('active');
    });

    // Filtreleme fonksiyonlarını global olarak tanımlayın
    window.toggleFilter = function (columnIndex) {
        const filterInputs = document.querySelectorAll('thead tr th input');
        if (filterInputs[columnIndex]) {
            filterInputs[columnIndex].classList.toggle('d-none');
            if (!filterInputs[columnIndex].classList.contains('d-none')) {
                filterInputs[columnIndex].focus();
            }
        }
    };

    window.filterColumn = function (event, columnIndex) {
        const filterValue = event.target.value.toLowerCase();
        const table = document.getElementById('dataTable');
        const rows = table.querySelectorAll('tbody tr');

        rows.forEach(row => {
            const cell = row.querySelectorAll('td')[columnIndex];
            if (cell) {
                const cellText = cell.textContent.toLowerCase();
                row.style.display = cellText.includes(filterValue) ? '' : 'none';
            }
        });
    };

    console.log("Filtreleme fonksiyonları başarıyla yüklendi.");
});
