using LeaveManagementSystem.Models.LeaveTypes;

namespace LeaveManagementSystem.Services
{
    public interface ILeaveTypesService
    {
        Task<bool> CheckIfLeaveTypeExists(string name);
        Task<bool> CheckIfLeaveTypeExistsForEdit(LeaveTypeEditVm leaveTypeEdit);
        Task Create(LeaveTypeCreateVm model);
        Task Edit(LeaveTypeEditVm model);
        Task<T?> Get<T>(int id) where T : class;
        Task<List<LeaveTypeReadOnlyVM>> GetAllLeaveTypes();
        bool LeaveTypeExists(int? id);
        Task Remove(int id);
    }
}