namespace Government.Services.Formalities
{
    /// <summary>
    /// Thủ tục hành chính
    /// </summary>
    public enum FormalityType
    {
        /// <summary>
        /// Nothing
        /// </summary>
        None,
        /// <summary>
        /// Đăng ký giấy khai sinh
        /// </summary>
        RegBirthCertificate,
        /// <summary>
        /// Đăng ký giấy kết hôn
        /// </summary>
        RegMarriageCertificate,
        /// <summary>
        /// Đăng ký giấy chứng tử
        /// </summary>
        RegDeathCertificate,
        /// <summary>
        /// Đăng ký nhận giám hộ
        /// </summary>
        RegGuardianship,
        /// <summary>
        /// Đăng ký nhận cha, mẹ, con
        /// </summary>
        RegFatherMotherChild,
        /// <summary>
        /// Đăng ký cấp lại giấy khai sinh
        /// </summary>
        ReRegBirthCertificate,
        /// <summary>
        /// Đăng ký cấp lại giấy kết hôn
        /// </summary>
        ReRegMarriageCertificate,
        /// <summary>
        /// Đăng ký cấp lại giấy chứng tử
        /// </summary>
        ReRegDeatchCertificate,
        /// <summary>
        /// Yêu cầu thay đổi thông tin hộ tịch
        /// </summary>
        ReqCivilStatusChanges,
        /// <summary>
        /// Yêu cầu cấp bản sao hộ tịch
        /// </summary>
        ReqCivilstatusCopies,
        /// <summary>
        /// Yêu cầu giấy xác nhận tình trạng hôn nhân
        /// </summary>
        ReqMaritalStatusConfirm,
    }
}
