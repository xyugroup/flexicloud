import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ScodesComponent } from './scodes.component';

describe('ScodesComponent', () => {
  let component: ScodesComponent;
  let fixture: ComponentFixture<ScodesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ScodesComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ScodesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
