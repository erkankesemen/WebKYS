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
    const sidebar = document.getElementById('sidebar');
    const content = document.querySelector('.content');
    let overlay = document.createElement('div');
    overlay.className = 'overlay';
    document.body.appendChild(overlay);

    sidebarCollapse?.addEventListener('click', () => {
        sidebar.classList.toggle('active');
        overlay.classList.toggle('active');
        content.classList.toggle('pushed');
    });

    overlay.addEventListener('click', () => {
        sidebar.classList.remove('active');
        overlay.classList.remove('active');
        content.classList.remove('pushed');
    });

    // Ekran boyutu değiştiğinde
    window.addEventListener('resize', () => {
        if (window.innerWidth > 780) {
            overlay.classList.remove('active');
            content.classList.remove('pushed');
        }
    });

    // Kolon İkonlarına Tıklama Dinleyicisi
    document.querySelectorAll('.bi-filter').forEach((filterIcon, index) => {
        filterIcon.addEventListener('click', () => toggleFilter(index));
    });
});
