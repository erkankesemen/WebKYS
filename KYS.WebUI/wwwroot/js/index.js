
document.addEventListener("DOMContentLoaded", function () {




    const themeToggle = document.getElementById('themeToggle');
    const themeIcon = document.getElementById('themeIcon');
    const body = document.body;

    // Tema Değişimi
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

    const sidebarCollapse = document.getElementById('sidebarCollapse');
    sidebarCollapse?.addEventListener('click', () => {
        document.getElementById('sidebar').classList.toggle('active');
    });

    // Kolon İkonlarına Tıklama Dinleyicisi
    document.querySelectorAll('.bi-filter').forEach((filterIcon, index) => {
        filterIcon.addEventListener('click', () => toggleFilter(index));
    });
});
