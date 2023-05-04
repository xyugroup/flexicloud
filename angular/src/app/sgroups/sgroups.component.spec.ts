import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SgroupsComponent } from './sgroups.component';

describe('SgroupsComponent', () => {
  let component: SgroupsComponent;
  let fixture: ComponentFixture<SgroupsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SgroupsComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(SgroupsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
