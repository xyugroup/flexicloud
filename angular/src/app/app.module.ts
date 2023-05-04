import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientJsonpModule } from '@angular/common/http';
import { HttpClientModule } from '@angular/common/http';
import { ModalModule } from 'ngx-bootstrap/modal';
import { BsDropdownModule } from 'ngx-bootstrap/dropdown';
import { CollapseModule } from 'ngx-bootstrap/collapse';
import { TabsModule } from 'ngx-bootstrap/tabs';
import { NgxPaginationModule } from 'ngx-pagination';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ServiceProxyModule } from '@shared/service-proxies/service-proxy.module';
import { SharedModule } from '@shared/shared.module';
import { HomeComponent } from '@app/home/home.component';
import { AboutComponent } from '@app/about/about.component';
// tenants
import { TenantsComponent } from '@app/tenants/tenants.component';
import { CreateTenantDialogComponent } from './tenants/create-tenant/create-tenant-dialog.component';
import { EditTenantDialogComponent } from './tenants/edit-tenant/edit-tenant-dialog.component';
// roles
import { RolesComponent } from '@app/roles/roles.component';
import { CreateRoleDialogComponent } from './roles/create-role/create-role-dialog.component';
import { EditRoleDialogComponent } from './roles/edit-role/edit-role-dialog.component';
// users
import { UsersComponent } from '@app/users/users.component';
import { CreateUserDialogComponent } from '@app/users/create-user/create-user-dialog.component';
import { EditUserDialogComponent } from '@app/users/edit-user/edit-user-dialog.component';
import { ChangePasswordComponent } from './users/change-password/change-password.component';
import { ResetPasswordDialogComponent } from './users/reset-password/reset-password.component';
// entity
import { EntityComponent } from '@app/entity/entity.component';

// layout
import { HeaderComponent } from './layout/header.component';
import { HeaderLeftNavbarComponent } from './layout/header-left-navbar.component';
import { HeaderLanguageMenuComponent } from './layout/header-language-menu.component';
import { HeaderUserMenuComponent } from './layout/header-user-menu.component';
import { FooterComponent } from './layout/footer.component';
import { SidebarComponent } from './layout/sidebar.component';
import { SidebarLogoComponent } from './layout/sidebar-logo.component';
import { SidebarUserPanelComponent } from './layout/sidebar-user-panel.component';
import { SidebarMenuComponent } from './layout/sidebar-menu.component';
import { SettingsComponent } from './settings/settings.component';
import { CompanyComponent } from './company/company.component';
import { CodeComponent } from './code/code.component';
import { GtablesComponent } from './gtables/gtables.component';
import { BcodesComponent } from './bcodes/bcodes.component';
import { PtcodesComponent } from './ptcodes/ptcodes.component';
import { SgroupsComponent } from './sgroups/sgroups.component';
import { ScodesComponent } from './scodes/scodes.component';
import { IschedulesComponent } from './ischedules/ischedules.component';
import { HtablesComponent } from './htables/htables.component';
import { CmethodsComponent } from './cmethods/cmethods.component';
import { NscutoffsComponent } from './nscutoffs/nscutoffs.component';
import { SdtablesComponent } from './sdtables/sdtables.component';
import { TreceiptsComponent } from './treceipts/treceipts.component';
import { EmployeesComponent } from './employees/employees.component';
import { FptransComponent } from './fptrans/fptrans.component';
import { TreliefsComponent } from './treliefs/treliefs.component';
import { ThistorysComponent } from './thistorys/thistorys.component';
import { BonusComponent } from './bonus/bonus.component';
import { BiksComponent } from './biks/biks.component';
import { LformsComponent } from './lforms/lforms.component';
import { HspaysComponent } from './hspays/hspays.component';
import { ApaysComponent } from './apays/apays.component';
import { ComputepayComponent } from './computepay/computepay.component';
import { ClosepayComponent } from './closepay/closepay.component';
import { AudittrailsComponent } from './audittrails/audittrails.component';





@NgModule({
    declarations: [
        AppComponent,
        HomeComponent,
        AboutComponent,
        // tenants
        TenantsComponent,
        CreateTenantDialogComponent,
        EditTenantDialogComponent,
        // roles
        RolesComponent,
        CreateRoleDialogComponent,
        EditRoleDialogComponent,
        // users
        UsersComponent,
        CreateUserDialogComponent,
        EditUserDialogComponent,
        ChangePasswordComponent,
        ResetPasswordDialogComponent,
        // layout
        HeaderComponent,
        HeaderLeftNavbarComponent,
        HeaderLanguageMenuComponent,
        HeaderUserMenuComponent,
        FooterComponent,
        SidebarComponent,
        SidebarLogoComponent,
        SidebarUserPanelComponent,
        SidebarMenuComponent,
        // entity
        EntityComponent,
        SettingsComponent,
        CompanyComponent,
        CodeComponent,
        GtablesComponent,
        BcodesComponent,
        PtcodesComponent,
        SgroupsComponent,
        ScodesComponent,
        IschedulesComponent,
        HtablesComponent,
        CmethodsComponent,
        NscutoffsComponent,
        SdtablesComponent,
        TreceiptsComponent,
        EmployeesComponent,
        FptransComponent,
        TreliefsComponent,
        ThistorysComponent,
        BonusComponent,
        BiksComponent,
        LformsComponent,
        HspaysComponent,
        ApaysComponent,
        ComputepayComponent,
        ClosepayComponent,
        AudittrailsComponent,

    ],
    imports: [
        CommonModule,
        FormsModule,
        ReactiveFormsModule,
        HttpClientModule,
        HttpClientJsonpModule,
        ModalModule.forChild(),
        BsDropdownModule,
        CollapseModule,
        TabsModule,
        AppRoutingModule,
        ServiceProxyModule,
        SharedModule,
        NgxPaginationModule,
    ],
    providers: []
})
export class AppModule {}
