document.addEventListener("DOMContentLoaded", function () {
    const modal = document.getElementById('registerModal');

    // Modal açıldığında
    modal.addEventListener('shown.bs.modal', () => {
        modal.removeAttribute('inert'); // Modal içeriğini etkinleştir
        modal.querySelector('input')?.focus(); // İlk odaklanabilir öğeye odaklan
    });
    
    // Modal kapatıldığında
    modal.addEventListener('hidden.bs.modal', () => {
        modal.setAttribute('inert', ''); // Modal içeriğini devre dışı bırak
    });
    
});
